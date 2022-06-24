
namespace LibraryInformationSystem.View
{
    partial class ucFrmReader
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
            this.readerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDReader = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderDOB = new System.Windows.Forms.TextBox();
            this.txtValidDate = new System.Windows.Forms.TextBox();
            this.txtReaderJob = new System.Windows.Forms.TextBox();
            this.txtExpiredDate = new System.Windows.Forms.TextBox();
            this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.readerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // readerGridView
            // 
            this.readerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReaderID,
            this.ReaderName,
            this.ReaderDOB,
            this.ReaderJob,
            this.ValidDate,
            this.ExpiredDate});
            this.readerGridView.Location = new System.Drawing.Point(0, 260);
            this.readerGridView.Name = "readerGridView";
            this.readerGridView.RowHeadersWidth = 51;
            this.readerGridView.RowTemplate.Height = 24;
            this.readerGridView.Size = new System.Drawing.Size(1085, 327);
            this.readerGridView.TabIndex = 0;
            this.readerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readerGridView_CellClick);
            this.readerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(123, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(123, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(123, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày tháng năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(448, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày đăng ký thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(448, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nghề nghiệp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(447, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày hết hạn thẻ";
            // 
            // txtIDReader
            // 
            this.txtIDReader.Location = new System.Drawing.Point(239, 79);
            this.txtIDReader.Name = "txtIDReader";
            this.txtIDReader.Size = new System.Drawing.Size(100, 22);
            this.txtIDReader.TabIndex = 2;
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(239, 131);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(100, 22);
            this.txtReaderName.TabIndex = 2;
            // 
            // txtReaderDOB
            // 
            this.txtReaderDOB.Location = new System.Drawing.Point(321, 181);
            this.txtReaderDOB.Name = "txtReaderDOB";
            this.txtReaderDOB.Size = new System.Drawing.Size(100, 22);
            this.txtReaderDOB.TabIndex = 2;
            // 
            // txtValidDate
            // 
            this.txtValidDate.Location = new System.Drawing.Point(618, 79);
            this.txtValidDate.Name = "txtValidDate";
            this.txtValidDate.Size = new System.Drawing.Size(100, 22);
            this.txtValidDate.TabIndex = 2;
            // 
            // txtReaderJob
            // 
            this.txtReaderJob.Location = new System.Drawing.Point(618, 181);
            this.txtReaderJob.Name = "txtReaderJob";
            this.txtReaderJob.Size = new System.Drawing.Size(100, 22);
            this.txtReaderJob.TabIndex = 2;
            // 
            // txtExpiredDate
            // 
            this.txtExpiredDate.Location = new System.Drawing.Point(618, 131);
            this.txtExpiredDate.Name = "txtExpiredDate";
            this.txtExpiredDate.Size = new System.Drawing.Size(100, 22);
            this.txtExpiredDate.TabIndex = 2;
            // 
            // ReaderID
            // 
            this.ReaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReaderID.DataPropertyName = "ReaderID";
            this.ReaderID.HeaderText = "ID";
            this.ReaderID.MinimumWidth = 6;
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.Width = 50;
            // 
            // ReaderName
            // 
            this.ReaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReaderName.DataPropertyName = "ReaderName";
            this.ReaderName.HeaderText = "Họ và tên";
            this.ReaderName.MinimumWidth = 6;
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Width = 98;
            // 
            // ReaderDOB
            // 
            this.ReaderDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReaderDOB.DataPropertyName = "ReaderDOB";
            this.ReaderDOB.HeaderText = "Sinh nhật";
            this.ReaderDOB.MinimumWidth = 6;
            this.ReaderDOB.Name = "ReaderDOB";
            this.ReaderDOB.Width = 97;
            // 
            // ReaderJob
            // 
            this.ReaderJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReaderJob.DataPropertyName = "ReaderJob";
            this.ReaderJob.HeaderText = "Nghề nghiệp";
            this.ReaderJob.MinimumWidth = 6;
            this.ReaderJob.Name = "ReaderJob";
            this.ReaderJob.Width = 118;
            // 
            // ValidDate
            // 
            this.ValidDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ValidDate.DataPropertyName = "ValidDate";
            this.ValidDate.HeaderText = "Ngày đăng ký thẻ";
            this.ValidDate.MinimumWidth = 6;
            this.ValidDate.Name = "ValidDate";
            this.ValidDate.Width = 118;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ExpiredDate.DataPropertyName = "ExpiredDate";
            this.ExpiredDate.HeaderText = "Ngày hết hạn thẻ";
            this.ExpiredDate.MinimumWidth = 6;
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.Width = 116;
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddReader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.ForeColor = System.Drawing.Color.White;
            this.btnAddReader.Location = new System.Drawing.Point(849, 79);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(75, 29);
            this.btnAddReader.TabIndex = 3;
            this.btnAddReader.Text = "Thêm";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(849, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteReader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReader.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReader.Location = new System.Drawing.Point(849, 173);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteReader.TabIndex = 3;
            this.btnDeleteReader.Text = "Xóa";
            this.btnDeleteReader.UseVisualStyleBackColor = false;
            this.btnDeleteReader.Click += new System.EventHandler(this.button3_Click);
            // 
            // ucFrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteReader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.txtReaderJob);
            this.Controls.Add(this.txtReaderDOB);
            this.Controls.Add(this.txtValidDate);
            this.Controls.Add(this.txtExpiredDate);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.txtIDReader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readerGridView);
            this.Name = "ucFrmReader";
            this.Size = new System.Drawing.Size(1088, 631);
            this.Load += new System.EventHandler(this.ucFrmReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView readerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDReader;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtReaderDOB;
        private System.Windows.Forms.TextBox txtValidDate;
        private System.Windows.Forms.TextBox txtReaderJob;
        private System.Windows.Forms.TextBox txtExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteReader;
    }
}
