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
        public ucFrmBooks()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ucFrmBooks_Load(object sender, EventArgs e)
        {
            Controller.BookController bookController = new Controller.BookController();
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
    }
}
