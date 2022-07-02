
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFrmReader));
            this.readerGridView = new System.Windows.Forms.DataGridView();
            this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDReader = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderJob = new System.Windows.Forms.TextBox();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            this.txtReaderDOB = new System.Windows.Forms.MaskedTextBox();
            this.txtValidDate = new System.Windows.Forms.MaskedTextBox();
            this.txtExpiredDate = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comFields = new System.Windows.Forms.ComboBox();
            this.comFieldsValue = new System.Windows.Forms.TextBox();
            this.btnSearchReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.readerGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readerGridView
            // 
            this.readerGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.readerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReaderID,
            this.ReaderName,
            this.ReaderDOB,
            this.ReaderJob,
            this.ValidDate,
            this.ExpiredDate});
            this.readerGridView.Location = new System.Drawing.Point(33, 256);
            this.readerGridView.Name = "readerGridView";
            this.readerGridView.RowHeadersWidth = 51;
            this.readerGridView.RowTemplate.Height = 24;
            this.readerGridView.Size = new System.Drawing.Size(693, 375);
            this.readerGridView.TabIndex = 0;
            this.readerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readerGridView_CellClick);
            this.readerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.ReaderName.Width = 91;
            // 
            // ReaderDOB
            // 
            this.ReaderDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReaderDOB.DataPropertyName = "ReaderDOB";
            this.ReaderDOB.HeaderText = "Sinh nhật";
            this.ReaderDOB.MinimumWidth = 6;
            this.ReaderDOB.Name = "ReaderDOB";
            this.ReaderDOB.Width = 90;
            // 
            // ReaderJob
            // 
            this.ReaderJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReaderJob.DataPropertyName = "ReaderJob";
            this.ReaderJob.HeaderText = "Nghề nghiệp";
            this.ReaderJob.MinimumWidth = 6;
            this.ReaderJob.Name = "ReaderJob";
            this.ReaderJob.Width = 109;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(803, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID độc giả";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(803, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(803, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày tháng năm sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(803, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày đăng ký thẻ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(803, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nghề nghiệp";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(803, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày hết hạn thẻ";
            // 
            // txtIDReader
            // 
            this.txtIDReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDReader.Location = new System.Drawing.Point(1001, 313);
            this.txtIDReader.Name = "txtIDReader";
            this.txtIDReader.Size = new System.Drawing.Size(100, 22);
            this.txtIDReader.TabIndex = 2;
            // 
            // txtReaderName
            // 
            this.txtReaderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderName.Location = new System.Drawing.Point(1001, 363);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(100, 22);
            this.txtReaderName.TabIndex = 2;
            // 
            // txtReaderJob
            // 
            this.txtReaderJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderJob.Location = new System.Drawing.Point(1001, 563);
            this.txtReaderJob.Name = "txtReaderJob";
            this.txtReaderJob.Size = new System.Drawing.Size(100, 22);
            this.txtReaderJob.TabIndex = 2;
            // 
            // btnAddReader
            // 
            this.btnAddReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddReader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.ForeColor = System.Drawing.Color.White;
            this.btnAddReader.Location = new System.Drawing.Point(998, 161);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(75, 29);
            this.btnAddReader.TabIndex = 3;
            this.btnAddReader.Text = "Thêm";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(998, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteReader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReader.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReader.Location = new System.Drawing.Point(998, 255);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteReader.TabIndex = 3;
            this.btnDeleteReader.Text = "Xóa";
            this.btnDeleteReader.UseVisualStyleBackColor = false;
            this.btnDeleteReader.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtReaderDOB
            // 
            this.txtReaderDOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderDOB.Location = new System.Drawing.Point(1001, 413);
            this.txtReaderDOB.Mask = "00/00/0000";
            this.txtReaderDOB.Name = "txtReaderDOB";
            this.txtReaderDOB.Size = new System.Drawing.Size(100, 22);
            this.txtReaderDOB.TabIndex = 4;
            this.txtReaderDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtValidDate
            // 
            this.txtValidDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValidDate.Location = new System.Drawing.Point(1001, 463);
            this.txtValidDate.Mask = "00/00/0000";
            this.txtValidDate.Name = "txtValidDate";
            this.txtValidDate.Size = new System.Drawing.Size(100, 22);
            this.txtValidDate.TabIndex = 4;
            this.txtValidDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtExpiredDate
            // 
            this.txtExpiredDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExpiredDate.Location = new System.Drawing.Point(1001, 513);
            this.txtExpiredDate.Mask = "00/00/0000";
            this.txtExpiredDate.Name = "txtExpiredDate";
            this.txtExpiredDate.Size = new System.Drawing.Size(100, 22);
            this.txtExpiredDate.TabIndex = 4;
            this.txtExpiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1140, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::LibraryInformationSystem.Properties.Resources.tải_xuống__2_;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(27, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quản lý danh mục độc giả";
            // 
            // comFields
            // 
            this.comFields.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comFields.FormattingEnabled = true;
            this.comFields.Items.AddRange(new object[] {
            "ID độc giả",
            "Họ và tên"});
            this.comFields.Location = new System.Drawing.Point(33, 137);
            this.comFields.Name = "comFields";
            this.comFields.Size = new System.Drawing.Size(121, 24);
            this.comFields.TabIndex = 8;
            this.comFields.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comFieldsValue
            // 
            this.comFieldsValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comFieldsValue.Location = new System.Drawing.Point(186, 137);
            this.comFieldsValue.Multiline = true;
            this.comFieldsValue.Name = "comFieldsValue";
            this.comFieldsValue.Size = new System.Drawing.Size(354, 24);
            this.comFieldsValue.TabIndex = 9;
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchReader.BackColor = System.Drawing.Color.White;
            this.btnSearchReader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReader.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearchReader.Location = new System.Drawing.Point(576, 132);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(115, 29);
            this.btnSearchReader.TabIndex = 10;
            this.btnSearchReader.Text = "Tìm kiếm";
            this.btnSearchReader.UseVisualStyleBackColor = false;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // ucFrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSearchReader);
            this.Controls.Add(this.comFieldsValue);
            this.Controls.Add(this.comFields);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExpiredDate);
            this.Controls.Add(this.txtValidDate);
            this.Controls.Add(this.txtReaderDOB);
            this.Controls.Add(this.btnDeleteReader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.txtReaderJob);
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
            this.Size = new System.Drawing.Size(1140, 631);
            this.Load += new System.EventHandler(this.ucFrmReader_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ucFrmReader_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.readerGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtReaderJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteReader;
        private System.Windows.Forms.MaskedTextBox txtReaderDOB;
        private System.Windows.Forms.MaskedTextBox txtValidDate;
        private System.Windows.Forms.MaskedTextBox txtExpiredDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comFields;
        private System.Windows.Forms.TextBox comFieldsValue;
        private System.Windows.Forms.Button btnSearchReader;
    }
}
