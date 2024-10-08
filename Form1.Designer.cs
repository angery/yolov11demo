namespace Yolov11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbDeviceList = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelUsedTime = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbDeviceList
            // 
            cmbDeviceList.FormattingEnabled = true;
            cmbDeviceList.Location = new Point(106, 12);
            cmbDeviceList.Name = "cmbDeviceList";
            cmbDeviceList.Size = new Size(523, 28);
            cmbDeviceList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "摄像头列表:";
            // 
            // button1
            // 
            button1.Location = new Point(644, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "重新加载";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(844, 11);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 3;
            button2.Text = "加载图片测试";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(744, 11);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "打开摄像头";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelUsedTime
            // 
            labelUsedTime.AutoSize = true;
            labelUsedTime.Location = new Point(646, 53);
            labelUsedTime.Name = "labelUsedTime";
            labelUsedTime.Size = new Size(82, 20);
            labelUsedTime.TabIndex = 5;
            labelUsedTime.Text = "耗时:0毫秒";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(949, 544);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(12, 53);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "加载模型";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 644);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(labelUsedTime);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cmbDeviceList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "YOLOV11测试";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDeviceList;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelUsedTime;
        private PictureBox pictureBox1;
        private Button button4;
    }
}
