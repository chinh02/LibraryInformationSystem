
namespace LibraryInformationSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnCirculation = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Location = new System.Drawing.Point(0, 121);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1067, 762);
            this.panelContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::LibraryInformationSystem.Properties.Resources.Logo_NEU__1_;
            this.pictureBox1.Location = new System.Drawing.Point(372, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelButton
            // 
            this.panelButton.BackgroundImage = global::LibraryInformationSystem.Properties.Resources.z3539597584523_ebcdb90caf96c1fcf47f77381b2388d0;
            this.panelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButton.Controls.Add(this.btnCirculation);
            this.panelButton.Controls.Add(this.btnBook);
            this.panelButton.Controls.Add(this.btnAuthor);
            this.panelButton.Controls.Add(this.btnReader);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1067, 554);
            this.panelButton.TabIndex = 3;
            this.panelButton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnCirculation
            // 
            this.btnCirculation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCirculation.AutoSize = true;
            this.btnCirculation.BackColor = System.Drawing.Color.White;
            this.btnCirculation.Location = new System.Drawing.Point(874, 51);
            this.btnCirculation.Name = "btnCirculation";
            this.btnCirculation.Size = new System.Drawing.Size(161, 46);
            this.btnCirculation.TabIndex = 0;
            this.btnCirculation.Text = "Quản lý mượn trả sách";
            this.btnCirculation.UseVisualStyleBackColor = false;
            this.btnCirculation.Click += new System.EventHandler(this.btnCirculation_Click);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBook.AutoSize = true;
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(20, 51);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(161, 46);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Quản lý sách";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAuthor.AutoSize = true;
            this.btnAuthor.BackColor = System.Drawing.Color.White;
            this.btnAuthor.Location = new System.Drawing.Point(592, 51);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(161, 46);
            this.btnAuthor.TabIndex = 0;
            this.btnAuthor.Text = "Danh mục tác giả";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnReader
            // 
            this.btnReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReader.AutoSize = true;
            this.btnReader.BackColor = System.Drawing.Color.White;
            this.btnReader.Location = new System.Drawing.Point(291, 51);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(161, 46);
            this.btnReader.TabIndex = 0;
            this.btnReader.Text = "Danh mục độc giả";
            this.btnReader.UseVisualStyleBackColor = false;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn đã đăng nhập vào hệ thống thông tin quản lý thư viện của trường đại học KTQD," +
    " vui lòng chọn các mục ở trên để tiếp tục";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelButton);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCirculation;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}