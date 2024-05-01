namespace exam_system
{
    partial class frm_ques3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ques3));
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            btnNext = new Button();
            picStatus = new PictureBox();
            lblQuestion1 = new Label();
            radioButton1 = new RadioButton();
            btnAnswer = new Button();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStatus).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(picStatus);
            groupBox1.Controls.Add(lblQuestion1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(btnAnswer);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 387);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 224);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(136, 24);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "All of the above";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Location = new Point(314, 287);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 48);
            btnNext.TabIndex = 7;
            btnNext.Text = "Close";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // picStatus
            // 
            picStatus.Image = (Image)resources.GetObject("picStatus.Image");
            picStatus.Location = new Point(226, 95);
            picStatus.Name = "picStatus";
            picStatus.Size = new Size(168, 153);
            picStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatus.TabIndex = 5;
            picStatus.TabStop = false;
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Font = new Font("Segoe UI", 10F);
            lblQuestion1.Location = new Point(14, 23);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new Size(400, 23);
            lblQuestion1.TabIndex = 0;
            lblQuestion1.Text = "(3). C# programming language is used to develop -";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 89);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Web apps";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(20, 287);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(271, 48);
            btnAnswer.TabIndex = 4;
            btnAnswer.Text = "Answer";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 134);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(121, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Desktop apps";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 179);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(119, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mobiles apps";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // frm_ques3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 410);
            Controls.Add(groupBox1);
            Name = "frm_ques3";
            Text = "frm_ques3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private Button btnNext;
        private PictureBox picStatus;
        private Label lblQuestion1;
        private RadioButton radioButton1;
        private Button btnAnswer;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}