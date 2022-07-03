
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
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelReaderID = new System.Windows.Forms.Label();
            this.labelReaderName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblValidDate = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtIDReader = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderJob = new System.Windows.Forms.TextBox();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.comFields = new System.Windows.Forms.ComboBox();
            this.comFieldsValue = new System.Windows.Forms.TextBox();
            this.btnSearchReader = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtReaderGender = new System.Windows.Forms.TextBox();
            this.txtReaderDOB = new System.Windows.Forms.TextBox();
            this.txtValidDate = new System.Windows.Forms.TextBox();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.buttonUpdateReader = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
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
            this.Gender,
            this.ReaderDOB,
            this.ReaderJob,
            this.ValidDate,
            this.ExpiredDate});
            this.readerGridView.Location = new System.Drawing.Point(130, 433);
            this.readerGridView.Name = "readerGridView";
            this.readerGridView.RowHeadersWidth = 51;
            this.readerGridView.RowTemplate.Height = 24;
            this.readerGridView.Size = new System.Drawing.Size(981, 375);
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
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
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
            // labelReaderID
            // 
            this.labelReaderID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelReaderID.AutoSize = true;
            this.labelReaderID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReaderID.ForeColor = System.Drawing.Color.Black;
            this.labelReaderID.Location = new System.Drawing.Point(43, 202);
            this.labelReaderID.Name = "labelReaderID";
            this.labelReaderID.Size = new System.Drawing.Size(125, 26);
            this.labelReaderID.TabIndex = 1;
            this.labelReaderID.Text = "ID độc giả:";
            this.labelReaderID.Click += new System.EventHandler(this.labelReaderID_Click);
            // 
            // labelReaderName
            // 
            this.labelReaderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelReaderName.AutoSize = true;
            this.labelReaderName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReaderName.ForeColor = System.Drawing.Color.Black;
            this.labelReaderName.Location = new System.Drawing.Point(50, 250);
            this.labelReaderName.Name = "labelReaderName";
            this.labelReaderName.Size = new System.Drawing.Size(118, 26);
            this.labelReaderName.TabIndex = 1;
            this.labelReaderName.Text = "Họ và tên:";
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(630, 202);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(121, 26);
            this.lblDOB.TabIndex = 1;
            this.lblDOB.Text = "Ngày sinh:";
            // 
            // lblValidDate
            // 
            this.lblValidDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValidDate.AutoSize = true;
            this.lblValidDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidDate.ForeColor = System.Drawing.Color.Black;
            this.lblValidDate.Location = new System.Drawing.Point(630, 297);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(198, 26);
            this.lblValidDate.TabIndex = 1;
            this.lblValidDate.Text = "Ngày đăng ký thẻ:";
            // 
            // lblJob
            // 
            this.lblJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJob.Location = new System.Drawing.Point(630, 250);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(148, 26);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Nghề nghiệp:";
            // 
            // txtIDReader
            // 
            this.txtIDReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDReader.Location = new System.Drawing.Point(196, 193);
            this.txtIDReader.Multiline = true;
            this.txtIDReader.Name = "txtIDReader";
            this.txtIDReader.Size = new System.Drawing.Size(288, 31);
            this.txtIDReader.TabIndex = 7;
            // 
            // txtReaderName
            // 
            this.txtReaderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderName.Location = new System.Drawing.Point(196, 240);
            this.txtReaderName.Multiline = true;
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(288, 32);
            this.txtReaderName.TabIndex = 8;
            // 
            // txtReaderJob
            // 
            this.txtReaderJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderJob.Location = new System.Drawing.Point(849, 241);
            this.txtReaderJob.Multiline = true;
            this.txtReaderJob.Name = "txtReaderJob";
            this.txtReaderJob.Size = new System.Drawing.Size(262, 31);
            this.txtReaderJob.TabIndex = 12;
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteReader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReader.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReader.Location = new System.Drawing.Point(630, 362);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(115, 37);
            this.btnDeleteReader.TabIndex = 6;
            this.btnDeleteReader.Text = "Xóa";
            this.btnDeleteReader.UseVisualStyleBackColor = false;
            this.btnDeleteReader.Click += new System.EventHandler(this.button3_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1187, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 34);
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
            this.comFields.Location = new System.Drawing.Point(235, 118);
            this.comFields.Name = "comFields";
            this.comFields.Size = new System.Drawing.Size(121, 24);
            this.comFields.TabIndex = 1;
            this.comFields.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comFieldsValue
            // 
            this.comFieldsValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comFieldsValue.Location = new System.Drawing.Point(387, 107);
            this.comFieldsValue.Multiline = true;
            this.comFieldsValue.Name = "comFieldsValue";
            this.comFieldsValue.Size = new System.Drawing.Size(364, 43);
            this.comFieldsValue.TabIndex = 2;
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchReader.BackColor = System.Drawing.Color.White;
            this.btnSearchReader.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReader.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearchReader.Location = new System.Drawing.Point(782, 107);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(124, 43);
            this.btnSearchReader.TabIndex = 3;
            this.btnSearchReader.Text = "Tìm kiếm";
            this.btnSearchReader.UseVisualStyleBackColor = false;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(50, 297);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(112, 26);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Giới tính:";
            // 
            // txtReaderGender
            // 
            this.txtReaderGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderGender.Location = new System.Drawing.Point(196, 287);
            this.txtReaderGender.Multiline = true;
            this.txtReaderGender.Name = "txtReaderGender";
            this.txtReaderGender.Size = new System.Drawing.Size(288, 32);
            this.txtReaderGender.TabIndex = 9;
            // 
            // txtReaderDOB
            // 
            this.txtReaderDOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderDOB.Location = new System.Drawing.Point(849, 194);
            this.txtReaderDOB.Multiline = true;
            this.txtReaderDOB.Name = "txtReaderDOB";
            this.txtReaderDOB.Size = new System.Drawing.Size(262, 30);
            this.txtReaderDOB.TabIndex = 10;
            this.txtReaderDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValidDate
            // 
            this.txtValidDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValidDate.Location = new System.Drawing.Point(849, 288);
            this.txtValidDate.Multiline = true;
            this.txtValidDate.Name = "txtValidDate";
            this.txtValidDate.Size = new System.Drawing.Size(262, 31);
            this.txtValidDate.TabIndex = 11;
            this.txtValidDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFunction
            // 
            this.btnFunction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFunction.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFunction.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.ForeColor = System.Drawing.Color.White;
            this.btnFunction.Location = new System.Drawing.Point(858, 362);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(135, 37);
            this.btnFunction.TabIndex = 4;
            this.btnFunction.Text = "Cập nhật";
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Visible = false;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddReader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.ForeColor = System.Drawing.Color.White;
            this.btnAddReader.Location = new System.Drawing.Point(153, 362);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(133, 37);
            this.btnAddReader.TabIndex = 4;
            this.btnAddReader.Text = "Thêm";
            this.btnAddReader.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdateReader
            // 
            this.buttonUpdateReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdateReader.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUpdateReader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateReader.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateReader.Location = new System.Drawing.Point(399, 362);
            this.buttonUpdateReader.Name = "buttonUpdateReader";
            this.buttonUpdateReader.Size = new System.Drawing.Size(118, 37);
            this.buttonUpdateReader.TabIndex = 5;
            this.buttonUpdateReader.Text = "Sửa";
            this.buttonUpdateReader.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateReader.UseVisualStyleBackColor = false;
            this.buttonUpdateReader.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // ucFrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::LibraryInformationSystem.Properties.Resources.Free_vector_000477_nen_mau_nuoc_may;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSearchReader);
            this.Controls.Add(this.comFieldsValue);
            this.Controls.Add(this.comFields);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteReader);
            this.Controls.Add(this.buttonUpdateReader);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.txtReaderJob);
            this.Controls.Add(this.txtValidDate);
            this.Controls.Add(this.txtReaderDOB);
            this.Controls.Add(this.txtReaderGender);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.txtIDReader);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblValidDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.labelReaderName);
            this.Controls.Add(this.labelReaderID);
            this.Controls.Add(this.readerGridView);
            this.Name = "ucFrmReader";
            this.Size = new System.Drawing.Size(1187, 733);
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
        private System.Windows.Forms.Label labelReaderID;
        private System.Windows.Forms.Label labelReaderName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblValidDate;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtIDReader;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtReaderJob;
        private System.Windows.Forms.Button buttonUpdateReader;
        private System.Windows.Forms.Button btnDeleteReader;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtReaderGender;
        private System.Windows.Forms.TextBox txtReaderDOB;
        private System.Windows.Forms.TextBox txtValidDate;
        private System.Windows.Forms.Button btnFunction;
        internal System.Windows.Forms.Button btnAddReader;
    }
}
