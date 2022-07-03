
namespace LibraryInformationSystem.View
{
    partial class ucFrmAuthor
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
            this.grdAuthor = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtAuthorYOB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAuthor
            // 
            this.grdAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdAuthor.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.AuthorName,
            this.YOB});
            this.grdAuthor.Location = new System.Drawing.Point(40, 158);
            this.grdAuthor.Name = "grdAuthor";
            this.grdAuthor.RowHeadersWidth = 51;
            this.grdAuthor.RowTemplate.Height = 24;
            this.grdAuthor.Size = new System.Drawing.Size(664, 310);
            this.grdAuthor.TabIndex = 0;
            this.grdAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAuthor_CellClick);
            this.grdAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "Mã tác giả";
            this.AuthorID.MinimumWidth = 6;
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Width = 125;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "Tên tác giả";
            this.AuthorName.MinimumWidth = 6;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Width = 125;
            // 
            // YOB
            // 
            this.YOB.DataPropertyName = "YOB";
            this.YOB.HeaderText = "Năm sinh";
            this.YOB.MinimumWidth = 6;
            this.YOB.Name = "YOB";
            this.YOB.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(351, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý danh mục tác giả";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(735, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã tác giả:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(735, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tác giả:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(735, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm sinh:";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthorID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorID.Location = new System.Drawing.Point(882, 212);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(209, 34);
            this.txtAuthorID.TabIndex = 3;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthorName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(882, 286);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(209, 34);
            this.txtAuthorName.TabIndex = 3;
            // 
            // txtAuthorYOB
            // 
            this.txtAuthorYOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthorYOB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorYOB.Location = new System.Drawing.Point(882, 358);
            this.txtAuthorYOB.Name = "txtAuthorYOB";
            this.txtAuthorYOB.Size = new System.Drawing.Size(209, 34);
            this.txtAuthorYOB.TabIndex = 3;
            // 
            // ucFrmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibraryInformationSystem.Properties.Resources.Free_vector_000477_nen_mau_nuoc_may;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtAuthorYOB);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdAuthor);
            this.Name = "ucFrmAuthor";
            this.Size = new System.Drawing.Size(1125, 621);
            this.Load += new System.EventHandler(this.ucFrmAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtAuthorYOB;
    }
}
