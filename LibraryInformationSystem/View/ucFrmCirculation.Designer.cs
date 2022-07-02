
namespace LibraryInformationSystem.View
{
    partial class ucFrmCirculation
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbReader = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtSupposedReturn = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBorrowedDate = new System.Windows.Forms.TextBox();
            this.txtActualReturn = new System.Windows.Forms.TextBox();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.txtBookIDCir = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActualReturn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdCirculation = new System.Windows.Forms.DataGridView();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupposedReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryMngDataSet = new LibraryInformationSystem.LibraryMngDataSet();
            this.circulationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circulationsTableAdapter = new LibraryInformationSystem.LibraryMngDataSetTableAdapters.CirculationsTableAdapter();
            this.extendGroup = new System.Windows.Forms.GroupBox();
            this.grpTimeExtend = new System.Windows.Forms.GroupBox();
            this.rb1Week = new System.Windows.Forms.RadioButton();
            this.rb2Week = new System.Windows.Forms.RadioButton();
            this.btnConfirmExtend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCirculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulationsBindingSource)).BeginInit();
            this.extendGroup.SuspendLayout();
            this.grpTimeExtend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(68, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(815, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Location = new System.Drawing.Point(469, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 54);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(37, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbReader);
            this.groupBox3.Controls.Add(this.rbBook);
            this.groupBox3.Location = new System.Drawing.Point(18, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 79);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm theo";
            // 
            // rbReader
            // 
            this.rbReader.AutoSize = true;
            this.rbReader.Location = new System.Drawing.Point(119, 33);
            this.rbReader.Name = "rbReader";
            this.rbReader.Size = new System.Drawing.Size(98, 21);
            this.rbReader.TabIndex = 1;
            this.rbReader.TabStop = true;
            this.rbReader.Text = "Mã độc giả";
            this.rbReader.UseVisualStyleBackColor = true;
            this.rbReader.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(20, 33);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(93, 21);
            this.rbBook.TabIndex = 0;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Mã tài liệu";
            this.rbBook.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.txtBookAuthor);
            this.groupBox5.Controls.Add(this.txtBookName);
            this.groupBox5.Controls.Add(this.txtBookID);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(68, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 172);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin sách";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(124, 100);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtBookAuthor.TabIndex = 3;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(123, 61);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 22);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(123, 22);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tài liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài liệu";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.txtStatus);
            this.groupBox6.Controls.Add(this.txtNote);
            this.groupBox6.Controls.Add(this.txtSupposedReturn);
            this.groupBox6.Controls.Add(this.btnUpdate);
            this.groupBox6.Controls.Add(this.txtBorrowedDate);
            this.groupBox6.Controls.Add(this.txtActualReturn);
            this.groupBox6.Controls.Add(this.txtReaderID);
            this.groupBox6.Controls.Add(this.txtBookIDCir);
            this.groupBox6.Controls.Add(this.txtCardID);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.lblCardID);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.lblActualReturn);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(473, 194);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(542, 206);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thực hiện cho mượn sách";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(413, 104);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(413, 141);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 22);
            this.txtNote.TabIndex = 1;
            // 
            // txtSupposedReturn
            // 
            this.txtSupposedReturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupposedReturn.Location = new System.Drawing.Point(413, 69);
            this.txtSupposedReturn.Name = "txtSupposedReturn";
            this.txtSupposedReturn.Size = new System.Drawing.Size(100, 30);
            this.txtSupposedReturn.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Location = new System.Drawing.Point(220, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cho mượn";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBorrowedDate
            // 
            this.txtBorrowedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowedDate.Location = new System.Drawing.Point(413, 33);
            this.txtBorrowedDate.Name = "txtBorrowedDate";
            this.txtBorrowedDate.Size = new System.Drawing.Size(100, 30);
            this.txtBorrowedDate.TabIndex = 1;
            // 
            // txtActualReturn
            // 
            this.txtActualReturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualReturn.Location = new System.Drawing.Point(147, 137);
            this.txtActualReturn.Multiline = true;
            this.txtActualReturn.Name = "txtActualReturn";
            this.txtActualReturn.Size = new System.Drawing.Size(100, 22);
            this.txtActualReturn.TabIndex = 1;
            // 
            // txtReaderID
            // 
            this.txtReaderID.Location = new System.Drawing.Point(147, 104);
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(100, 22);
            this.txtReaderID.TabIndex = 1;
            // 
            // txtBookIDCir
            // 
            this.txtBookIDCir.Location = new System.Drawing.Point(147, 68);
            this.txtBookIDCir.Name = "txtBookIDCir";
            this.txtBookIDCir.Size = new System.Drawing.Size(100, 22);
            this.txtBookIDCir.TabIndex = 1;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(147, 32);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(100, 22);
            this.txtCardID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ghi chú";
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tình trạng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardID.Location = new System.Drawing.Point(25, 32);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(84, 22);
            this.lblCardID.TabIndex = 0;
            this.lblCardID.Text = "Mã phiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày hẹn trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sách";
            // 
            // lblActualReturn
            // 
            this.lblActualReturn.AutoSize = true;
            this.lblActualReturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualReturn.Location = new System.Drawing.Point(25, 140);
            this.lblActualReturn.Name = "lblActualReturn";
            this.lblActualReturn.Size = new System.Drawing.Size(116, 22);
            this.lblActualReturn.TabIndex = 0;
            this.lblActualReturn.Text = "Ngày thực trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã độc giả";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(361, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 42);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Mượn mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExtend.Location = new System.Drawing.Point(522, 429);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(75, 42);
            this.btnExtend.TabIndex = 3;
            this.btnExtend.Text = "Gia hạn";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.Location = new System.Drawing.Point(677, 429);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 42);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // grdCirculation
            // 
            this.grdCirculation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdCirculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCirculation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardID,
            this.BookID,
            this.ReaderID,
            this.BorrowedDate,
            this.SupposedReturn,
            this.ActualReturn,
            this.Status,
            this.Note});
            this.grdCirculation.Location = new System.Drawing.Point(105, 516);
            this.grdCirculation.Name = "grdCirculation";
            this.grdCirculation.RowHeadersWidth = 51;
            this.grdCirculation.RowTemplate.Height = 24;
            this.grdCirculation.Size = new System.Drawing.Size(893, 237);
            this.grdCirculation.TabIndex = 4;
            this.grdCirculation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCirculation_CellClick);
            // 
            // CardID
            // 
            this.CardID.DataPropertyName = "CardID";
            this.CardID.HeaderText = "Mã phiếu";
            this.CardID.MinimumWidth = 6;
            this.CardID.Name = "CardID";
            this.CardID.Width = 125;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "Mã sách";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.Width = 125;
            // 
            // ReaderID
            // 
            this.ReaderID.DataPropertyName = "ReaderID";
            this.ReaderID.HeaderText = "Mã độc giả";
            this.ReaderID.MinimumWidth = 6;
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.Width = 125;
            // 
            // BorrowedDate
            // 
            this.BorrowedDate.DataPropertyName = "BorrowedDate";
            this.BorrowedDate.HeaderText = "Ngày mượn";
            this.BorrowedDate.MinimumWidth = 6;
            this.BorrowedDate.Name = "BorrowedDate";
            this.BorrowedDate.Width = 125;
            // 
            // SupposedReturn
            // 
            this.SupposedReturn.DataPropertyName = "SupposedReturn";
            this.SupposedReturn.HeaderText = "Ngày phải trả";
            this.SupposedReturn.MinimumWidth = 6;
            this.SupposedReturn.Name = "SupposedReturn";
            this.SupposedReturn.Width = 125;
            // 
            // ActualReturn
            // 
            this.ActualReturn.DataPropertyName = "ActualReturn";
            this.ActualReturn.HeaderText = "Ngày trả thực tế";
            this.ActualReturn.MinimumWidth = 6;
            this.ActualReturn.Name = "ActualReturn";
            this.ActualReturn.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // libraryMngDataSet
            // 
            this.libraryMngDataSet.DataSetName = "LibraryMngDataSet";
            this.libraryMngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // circulationsBindingSource
            // 
            this.circulationsBindingSource.DataMember = "Circulations";
            this.circulationsBindingSource.DataSource = this.libraryMngDataSet;
            // 
            // circulationsTableAdapter
            // 
            this.circulationsTableAdapter.ClearBeforeFill = true;
            // 
            // extendGroup
            // 
            this.extendGroup.Controls.Add(this.btnConfirmExtend);
            this.extendGroup.Controls.Add(this.grpTimeExtend);
            this.extendGroup.Location = new System.Drawing.Point(398, 216);
            this.extendGroup.Name = "extendGroup";
            this.extendGroup.Size = new System.Drawing.Size(354, 207);
            this.extendGroup.TabIndex = 5;
            this.extendGroup.TabStop = false;
            this.extendGroup.Text = "Xác nhận gia hạn";
            this.extendGroup.Visible = false;
            this.extendGroup.Enter += new System.EventHandler(this.extendGroup_Enter);
            // 
            // grpTimeExtend
            // 
            this.grpTimeExtend.Controls.Add(this.rb2Week);
            this.grpTimeExtend.Controls.Add(this.rb1Week);
            this.grpTimeExtend.Location = new System.Drawing.Point(104, 71);
            this.grpTimeExtend.Name = "grpTimeExtend";
            this.grpTimeExtend.Size = new System.Drawing.Size(200, 100);
            this.grpTimeExtend.TabIndex = 0;
            this.grpTimeExtend.TabStop = false;
            this.grpTimeExtend.Text = "Thời hạn";
            // 
            // rb1Week
            // 
            this.rb1Week.AutoSize = true;
            this.rb1Week.Location = new System.Drawing.Point(7, 34);
            this.rb1Week.Name = "rb1Week";
            this.rb1Week.Size = new System.Drawing.Size(69, 21);
            this.rb1Week.TabIndex = 0;
            this.rb1Week.TabStop = true;
            this.rb1Week.Text = "1 tuần";
            this.rb1Week.UseVisualStyleBackColor = true;
            // 
            // rb2Week
            // 
            this.rb2Week.AutoSize = true;
            this.rb2Week.Location = new System.Drawing.Point(7, 71);
            this.rb2Week.Name = "rb2Week";
            this.rb2Week.Size = new System.Drawing.Size(69, 21);
            this.rb2Week.TabIndex = 1;
            this.rb2Week.TabStop = true;
            this.rb2Week.Text = "2 tuần";
            this.rb2Week.UseVisualStyleBackColor = true;
            // 
            // btnConfirmExtend
            // 
            this.btnConfirmExtend.Location = new System.Drawing.Point(124, 170);
            this.btnConfirmExtend.Name = "btnConfirmExtend";
            this.btnConfirmExtend.Size = new System.Drawing.Size(96, 31);
            this.btnConfirmExtend.TabIndex = 1;
            this.btnConfirmExtend.Text = "Xác nhận";
            this.btnConfirmExtend.UseVisualStyleBackColor = true;
            this.btnConfirmExtend.Click += new System.EventHandler(this.btnConfirmExtend_Click);
            // 
            // ucFrmCirculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.extendGroup);
            this.Controls.Add(this.grdCirculation);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucFrmCirculation";
            this.Size = new System.Drawing.Size(1145, 779);
            this.Load += new System.EventHandler(this.ucFrmCirculation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCirculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulationsBindingSource)).EndInit();
            this.extendGroup.ResumeLayout(false);
            this.grpTimeExtend.ResumeLayout(false);
            this.grpTimeExtend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbReader;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.TextBox txtBookIDCir;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdCirculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupposedReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtActualReturn;
        private System.Windows.Forms.Label lblActualReturn;
        private System.Windows.Forms.BindingSource circulationsBindingSource;
        private LibraryMngDataSet libraryMngDataSet;
        private LibraryMngDataSetTableAdapters.CirculationsTableAdapter circulationsTableAdapter;
        private System.Windows.Forms.TextBox txtSupposedReturn;
        private System.Windows.Forms.TextBox txtBorrowedDate;
        private System.Windows.Forms.GroupBox extendGroup;
        private System.Windows.Forms.Button btnConfirmExtend;
        private System.Windows.Forms.GroupBox grpTimeExtend;
        private System.Windows.Forms.RadioButton rb2Week;
        private System.Windows.Forms.RadioButton rb1Week;
    }
}
