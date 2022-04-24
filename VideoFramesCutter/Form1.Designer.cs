
namespace VideoFramesCutter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.frames_step_num = new System.Windows.Forms.NumericUpDown();
            this.compare_threshold_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.cutsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lastDelta = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.frames_step_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compare_threshold_num)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(12, 109);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(218, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 20);
            this.textBox1.TabIndex = 1;
            // 
            // frames_step_num
            // 
            this.frames_step_num.Location = new System.Drawing.Point(110, 48);
            this.frames_step_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frames_step_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frames_step_num.Name = "frames_step_num";
            this.frames_step_num.Size = new System.Drawing.Size(120, 20);
            this.frames_step_num.TabIndex = 2;
            this.frames_step_num.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // compare_threshold_num
            // 
            this.compare_threshold_num.Location = new System.Drawing.Point(110, 74);
            this.compare_threshold_num.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.compare_threshold_num.Name = "compare_threshold_num";
            this.compare_threshold_num.Size = new System.Drawing.Size(120, 20);
            this.compare_threshold_num.TabIndex = 3;
            this.compare_threshold_num.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Compare threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Step seconds";
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(236, 109);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(218, 23);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.cutsCount,
            this.lastDelta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(692, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // cutsCount
            // 
            this.cutsCount.Name = "cutsCount";
            this.cutsCount.Size = new System.Drawing.Size(13, 17);
            this.cutsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filename";
            // 
            // lastDelta
            // 
            this.lastDelta.Name = "lastDelta";
            this.lastDelta.Size = new System.Drawing.Size(562, 17);
            this.lastDelta.Spring = true;
            this.lastDelta.Text = "0";
            this.lastDelta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 201);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compare_threshold_num);
            this.Controls.Add(this.frames_step_num);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "VideoFramesCutter";
            ((System.ComponentModel.ISupportInitialize)(this.frames_step_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compare_threshold_num)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown frames_step_num;
        private System.Windows.Forms.NumericUpDown compare_threshold_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel cutsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lastDelta;
    }
}

