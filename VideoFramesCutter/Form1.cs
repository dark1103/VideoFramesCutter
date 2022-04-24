using MediaToolkit.Model;
using MediaToolkit.Options;
using MediaToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Collections;
using System.Collections.Concurrent;

namespace VideoFramesCutter
{
    public partial class Form1 : Form
    {
        private bool stop = true;
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBox1.Text = files[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!stop)
            {
                return;
            }

            string filename = textBox1.Text;
            string outputPath = Path.Combine(Path.GetFullPath(Path.GetDirectoryName(filename)),
                Path.GetFileNameWithoutExtension(filename) + "_pics");
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            stop = false;
            cutsCount.Text = "0";

            int step = (int)frames_step_num.Value;
            int lastProgress = 0;
            uint compareThr = (uint)compare_threshold_num.Value;

            Task.Run(() =>
            {
                int k = 1;
                using (var vFReader = new VideoFileReader())
                {
                    vFReader.Open(filename);
                    Bitmap bmp1 = null;
                    Bitmap bmp2 = null;
                    Bitmap bmpToSave = null;

                    bmp1 = vFReader.ReadVideoFrame();
                    step *= (int) vFReader.FrameRate.Value;

                    int t = 0;
                    for (int i = 1; i < vFReader.FrameCount && !stop; i++)
                    {
                        bmp2 = vFReader.ReadVideoFrame();

                        if (t++ == step || i == 1)
                        {
                            t = 0;
                            this.Invoke(new Action(() =>
                            {
                                toolStripProgressBar1.Value = (int)(100 * i / vFReader.FrameCount);
                            }));

                            try
                            {
                                bmpToSave = (Bitmap)bmp2.Clone();

                                var delta = CompareBitmaps(BitmapToBites(bmp1), BitmapToBites(bmp2));
                                lastDelta.Text = delta.ToString();

                                if (k == 1 || delta > compareThr)
                                {
                                    bmpToSave.Save(Path.Combine(outputPath, k + ".jpg"), ImageFormat.Jpeg);
                                    this.Invoke(new Action(() =>
                                    {
                                        cutsCount.Text = k.ToString();
                                    }));
                                    k++;
                                }

                                bmp1.Dispose();
                                bmpToSave.Dispose();
                                bmp1 = bmp2;

                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                            }
                        }
                        else
                        {
                            bmp2.Dispose();
                        }
                    }

                    vFReader.Close();
                }

                this.Invoke(new Action(() =>
                {
                    toolStripProgressBar1.Value = 0;
                }));
                stop = true;
            });
        }


        private byte[] BitmapToBites(Bitmap bitmap)
        {
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            var length = bitmapData.Stride * bitmapData.Height;

            byte[] bytes = new byte[length];

            Marshal.Copy(bitmapData.Scan0, bytes, 0, length);
            bitmap.UnlockBits(bitmapData);

            return bytes;
        }

        private ulong CompareBitmaps(byte[] a1, byte[] a2)
        {
            var rangePartitioner = Partitioner.Create(0, a1.Length);


            Parallel.ForEach(rangePartitioner, (range, loopState) =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    a1[i] ^= a2[i];
                }
            });

            ulong sum = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                sum += a1[i];
            }

            sum = 10000 * sum / (ulong)a1.Length / byte.MaxValue;

            return sum;
        }

        private int CompareBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            int sum = 0;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    var p = bmp1.GetPixel(i, j).ToArgb() ^ bmp2.GetPixel(i, j).ToArgb();
                    sum += p;
                }
            }

            return sum;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}