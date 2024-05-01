namespace exam_system
{
    partial class frm_ques2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ques2));
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
            radioButton4.Size = new Size(154, 24);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "None of the above";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Location = new Point(339, 287);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(55, 48);
            btnNext.TabIndex = 7;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // picStatus
            // 
            picStatus.Image = (Image)resources.GetObject("picStatus.Image");
            picStatus.Location = new Point(227, 89);
            picStatus.Name = "picStatus";
            picStatus.Size = new Size(167, 159);
            picStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatus.TabIndex = 5;
            picStatus.TabStop = false;
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Font = new Font("Segoe UI", 10F);
            lblQuestion1.Location = new Point(6, 23);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new Size(182, 23);
            lblQuestion1.TabIndex = 0;
            lblQuestion1.Text = "(2). C# runs on the ___.";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 89);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = ".NET Framework";
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
            radioButton2.Size = new Size(165, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Java Virtual Machine";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 179);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(123, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Both A. and B.";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // frm_ques2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 412);
            Controls.Add(groupBox1);
            Name = "frm_ques2";
            Text = "frm_ques2";
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