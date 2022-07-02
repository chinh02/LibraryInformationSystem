
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCirculation = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelButton
            // 
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
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(0, 83);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1067, 800);
            this.panelContainer.TabIndex = 1;
            // 
            // btnAuthor
            // 
            this.btnAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAuthor.AutoSize = true;
            this.btnAuthor.Location = new System.Drawing.Point(612, 31);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(161, 46);
            this.btnAuthor.TabIndex = 0;
            this.btnAuthor.Text = "Danh mục tác giả";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnReader
            // 
            this.btnReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReader.AutoSize = true;
            this.btnReader.Location = new System.Drawing.Point(311, 31);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(161, 46);
            this.btnReader.TabIndex = 0;
            this.btnReader.Text = "Danh mục độc giả";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBook.AutoSize = true;
            this.btnBook.Location = new System.Drawing.Point(40, 31);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(161, 46);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Quản lý sách";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCirculation
            // 
            this.btnCirculation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCirculation.AutoSize = true;
            this.btnCirculation.Location = new System.Drawing.Point(894, 31);
            this.btnCirculation.Name = "btnCirculation";
            this.btnCirculation.Size = new System.Drawing.Size(161, 46);
            this.btnCirculation.TabIndex = 0;
            this.btnCirculation.Text = "Quản lý mượn trả sách";
            this.btnCirculation.UseVisualStyleBackColor = true;
            this.btnCirculation.Click += new System.EventHandler(this.btnCirculation_Click);
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
    }
}