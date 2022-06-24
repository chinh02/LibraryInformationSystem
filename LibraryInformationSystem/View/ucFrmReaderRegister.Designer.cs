
namespace LibraryInformationSystem.View
{
    partial class ucFrmReaderRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderOccupation = new System.Windows.Forms.TextBox();
            this.txtReaderDOB = new System.Windows.Forms.MaskedTextBox();
            this.btnSignUpUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryInformationSystem.Properties.Resources._3456388;
            this.pictureBox1.Location = new System.Drawing.Point(38, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghề nghiệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sinh nhật";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(361, 120);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(158, 22);
            this.txtReaderName.TabIndex = 2;
            // 
            // txtReaderOccupation
            // 
            this.txtReaderOccupation.Location = new System.Drawing.Point(361, 164);
            this.txtReaderOccupation.Name = "txtReaderOccupation";
            this.txtReaderOccupation.Size = new System.Drawing.Size(158, 22);
            this.txtReaderOccupation.TabIndex = 2;
            // 
            // txtReaderDOB
            // 
            this.txtReaderDOB.Location = new System.Drawing.Point(361, 204);
            this.txtReaderDOB.Mask = "00/00/0000";
            this.txtReaderDOB.Name = "txtReaderDOB";
            this.txtReaderDOB.Size = new System.Drawing.Size(158, 22);
            this.txtReaderDOB.TabIndex = 3;
            this.txtReaderDOB.ValidatingType = typeof(System.DateTime);
            // 
            // btnSignUpUser
            // 
            this.btnSignUpUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSignUpUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpUser.ForeColor = System.Drawing.Color.White;
            this.btnSignUpUser.Location = new System.Drawing.Point(319, 256);
            this.btnSignUpUser.Name = "btnSignUpUser";
            this.btnSignUpUser.Size = new System.Drawing.Size(77, 35);
            this.btnSignUpUser.TabIndex = 4;
            this.btnSignUpUser.Text = "Đăng ký";
            this.btnSignUpUser.UseVisualStyleBackColor = false;
            this.btnSignUpUser.Click += new System.EventHandler(this.btnSignUpUser_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(474, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(33, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đăng ký độc giả mới";
            // 
            // ucFrmReaderRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSignUpUser);
            this.Controls.Add(this.txtReaderDOB);
            this.Controls.Add(this.txtReaderOccupation);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucFrmReaderRegister";
            this.Size = new System.Drawing.Size(610, 362);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtReaderOccupation;
        private System.Windows.Forms.MaskedTextBox txtReaderDOB;
        private System.Windows.Forms.Button btnSignUpUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}
