using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryInformationSystem.View
{
    public partial class ucFrmBooks : UserControl
    {
        int i;
        string sql;
        Controller.DataProvider DataProvider = new Controller.DataProvider();
        bool AddNewFlag = false;
        bool UpdateFlag = false;
        bool DeleteFlag = false;
        Model.Book book = new Model.Book();
        Controller.BookController bookController = new Controller.BookController();
        public ucFrmBooks()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ucFrmBooks_Load(object sender, EventArgs e)
        {
            grdViewBook.DataSource = bookController.LoadBook();
        }

        private void comFieldsBook_SelectedIndexChanged(object sender, EventArgs e)
        {   if (comFieldsBook.Text == "Tác giả") {
            sql = "Select Distinct AuthorName FROM LibMngm.Authors";
            comFieldsValueBook.DataSource = DataProvider.GetData(sql);
            comFieldsValueBook.DisplayMember = "AuthorName";
            } else if (comFieldsBook.Text == "Thể loại")
            {
                sql = "Select Distinct Genre FROM LibMngm.Books";
                comFieldsValueBook.DataSource = DataProvider.GetData(sql);
                comFieldsValueBook.DisplayMember = "Genre";
            } else if(comFieldsBook.Text == "Nhà xuất bản")
            {
                sql = "Select Distinct Publisher FROM LibMngm.Books";
                comFieldsValueBook.DataSource = DataProvider.GetData(sql);
                comFieldsValueBook.DisplayMember = "Publisher";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (comFieldsBook.Text == "Tác giả")
                {
                sql = "SELECT * FROM LibMngm.Books WHERE Author Like N'%" + comFieldsValueBook.Text + "%'";
                grdViewBook.DataSource = DataProvider.GetData(sql);
                loadDetails();
            }
                else if (comFieldsBook.Text == "Thể loại")
                {
                sql = "SELECT * FROM LibMngm.Books WHERE Genre Like N'%" + comFieldsValueBook.Text + "%'";
                grdViewBook.DataSource = DataProvider.GetData(sql);
                loadDetails();
            }
                else if (comFieldsBook.Text == "Nhà xuất bản")
                {
                sql = "SELECT * FROM LibMngm.Books WHERE Publisher Like N'%" + comFieldsValueBook.Text + "%'";
                grdViewBook.DataSource = DataProvider.GetData(sql);
                loadDetails();
            }
            }

        private void loadDetails()
        {
            i = grdViewBook.CurrentRow.Index;
            txtID.Text = grdViewBook.Rows[i].Cells["BookID"].Value.ToString();
            txtTitle.Text = grdViewBook.Rows[i].Cells["Title"].Value.ToString();
            txtAuthor.Text = grdViewBook.Rows[i].Cells["Author"].Value.ToString();
            txtGenre.Text = grdViewBook.Rows[i].Cells["Genre"].Value.ToString();
            txtPublisher.Text = grdViewBook.Rows[i].Cells["Publisher"].Value.ToString();
        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();
        }

        private void grdViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            i = grdViewBook.RowCount;
            grdViewBook.CurrentCell = grdViewBook[0, i - 1];
            txtAuthor.Focus();
            AddNewFlag = true;
            DeleteFlag = false;
            UpdateFlag = false;
            MessageBox.Show("Điền thông tin và ấn vào nút Cập nhật để thêm mới dữ liệu");
            btnFunction.Visible = true;
            txtID.Visible = false;
            lblID.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddNewFlag = false;
            DeleteFlag = false;
            UpdateFlag = true;
            MessageBox.Show("Điền thông tin và ấn vào nút Cập nhật để sửa dữ liệu");
            btnFunction.Visible = true;
            txtID.Visible = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AddNewFlag = false;
            DeleteFlag = true;
            UpdateFlag = false;
            MessageBox.Show("Chọn ô dữ liệu muốn xóa và ấn nút cập nhật để xóa");
            btnFunction.Visible = true;

        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (AddNewFlag == true)
            {
                book.bookTitle = txtTitle.Text;
                book.bookPublisher = txtPublisher.Text;
                book.bookGenre = txtGenre.Text;
                book.bookAuthor = txtAuthor.Text;
                bookController.AddBook(book);
                txtID.Visible = true;
                lblID.Visible = true;
                ucFrmBooks_Load(sender, e);

            }
            else if (UpdateFlag == true)
            {
                book.bookTitle = txtTitle.Text;
                book.bookPublisher = txtPublisher.Text;
                book.bookGenre = txtGenre.Text;
                book.bookAuthor = txtAuthor.Text;
                bookController.UpdateBook(book);
                txtID.Visible = true;
                lblID.Visible = true;
                ucFrmBooks_Load(sender, e);
               
            }
            else if (DeleteFlag == true)
            {
                if (txtID != null)
                {
                    bookController.DeleteBook(txtID.Text);
                }
            }
        }

        private void btnReportBook_Click(object sender, EventArgs e)
        {
            string fields;
            if(comFieldsBook.Text == "Tác giả") {
            fields = "Author";
            rpbooks rpt = new rpbooks();
            rpt.SetDataSource(bookController.LoadReport(fields, comFieldsValueBook.Text));
            ReportForm.frmRptBookList frm = new ReportForm.frmRptBookList(rpt);
            frm.Show();
            } else if(comFieldsBook.Text =="Thể loại")
            {
                fields = "Genre";
                rpbooks rpt = new rpbooks();
                rpt.SetDataSource(bookController.LoadReport(fields, comFieldsValueBook.Text));
                ReportForm.frmRptBookList frm = new ReportForm.frmRptBookList(rpt);
                frm.Show();
            } else if (comFieldsBook.Text =="Nhà xuất bản")
            {
                fields = "Publisher";
                rpbooks rpt = new rpbooks();
                rpt.SetDataSource(bookController.LoadReport(fields, comFieldsValueBook.Text));
                ReportForm.frmRptBookList frm = new ReportForm.frmRptBookList(rpt);
                frm.Show();
            }
        }
    }
}
