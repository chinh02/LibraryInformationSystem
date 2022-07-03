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
    public partial class ucFrmAuthor : UserControl
    {
        int i;
        public bool AddNewFlag, UpdateFlag, DeleteFlag;
        Controller.AuthorController authorController = new Controller.AuthorController();
        Model.Author author = new Model.Author();


        public ucFrmAuthor()
        {
            InitializeComponent();
        }

        private void ucFrmAuthor_Load(object sender, EventArgs e)
        {
            grdAuthor.DataSource = authorController.LoadAuthor();
            AddNewFlag = false;
            UpdateFlag = false;
            DeleteFlag = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thông tin và ấn cập nhật để thêm mới dữ liệu");
            i = grdAuthor.RowCount;
            grdAuthor.CurrentCell = grdAuthor[0, i - 1];
            txtAuthorName.Focus();
            AddNewFlag = true;
            btnFunction.Visible = true;
            DeleteFlag = false;
            UpdateFlag = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn ô muốn sửa, nhập thông tin và ấn cập nhật để sửa dữ liệu");
            AddNewFlag = false;
            btnFunction.Visible = true;
            DeleteFlag = false;
            UpdateFlag = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ở ô này không ? Ấn cập nhật để xóa");
            AddNewFlag = false;
            btnFunction.Visible = true;
            DeleteFlag = true;
            UpdateFlag = false;
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (AddNewFlag == true)
            {   
                lblAuthorID.Visible = false;
                txtAuthorID.Visible = false;
                author.authorName = txtAuthorName.Text;
                author.authorYOB = txtAuthorYOB.Text;
                authorController.AddAuthor(author);
                ResetView();
                ucFrmAuthor_Load(sender, e);
            }
            else if (UpdateFlag == true)
            {
                author.authorID = txtAuthorID.Text;
                author.authorName = txtAuthorName.Text;
                author.authorYOB = txtAuthorYOB.Text;
                authorController.UpdateAuthor(author);
                ResetView();
                ucFrmAuthor_Load(sender, e);
            }
            else if (DeleteFlag == true)
            {
                if (txtAuthorID != null)
                {
                    authorController.DeleteAuthor(txtAuthorID.Text);
                    ResetView();
                    ucFrmAuthor_Load(sender, e);
                }
            }
        }

        private void ResetView()
        {
            txtAuthorID.Clear();
            txtAuthorName.Clear();
            txtAuthorYOB.Clear();
            lblAuthorID.Visible = true;
            txtAuthorID.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rptauthor1 rpt = new rptauthor1();
            rpt.SetDataSource(authorController.LoadAuthor());
            ReportForm.frmAuthorList frm = new ReportForm.frmAuthorList(rpt);
            frm.Show();
        }

        private void loadDetails()
        {
            i = grdAuthor.CurrentRow.Index;
            txtAuthorID.Text = grdAuthor.Rows[i].Cells["AuthorID"].Value.ToString();
            txtAuthorName.Text = grdAuthor.Rows[i].Cells["AuthorName"].Value.ToString();
            txtAuthorYOB.Text = grdAuthor.Rows[i].Cells["YOB"].Value.ToString();
        }

        private void grdAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();
        }
    }
}
