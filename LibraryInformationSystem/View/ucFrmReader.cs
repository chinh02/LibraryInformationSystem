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
    public partial class ucFrmReader : UserControl
    {
        public bool AddNewFlag, UpdateFlag, DeleteFlag;
        Controller.ReaderController readerController = new Controller.ReaderController();


        public ucFrmReader()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucFrmReader_Load(object sender, EventArgs e)
        {
            
            readerGridView.DataSource = readerController.LoadReader();
            AddNewFlag = false;
            UpdateFlag = false;
            DeleteFlag = false;
        }

        private void readerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();
        }
        private void loadDetails()
        {
            //get details data
            int i = readerGridView.CurrentRow.Index;
            
            txtIDReader.Text = readerGridView.Rows[i].Cells["ReaderID"].Value.ToString();
            txtReaderName.Text = readerGridView.Rows[i].Cells["ReaderName"].Value.ToString();
            txtReaderDOB.Text = readerGridView.Rows[i].Cells["ReaderDOB"].Value.ToString();
            txtReaderJob.Text = readerGridView.Rows[i].Cells["ReaderJob"].Value.ToString();
            txtValidDate.Text = readerGridView.Rows[i].Cells["ValidDate"].Value.ToString();
            txtReaderGender.Text = readerGridView.Rows[i].Cells["Gender"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ở ô này không ? Ấn cập nhật để xóa");
            AddNewFlag = false;
            btnFunction.Visible = true;
            DeleteFlag = true;
            UpdateFlag = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thông tin và ấn cập nhật để thêm mới dữ liệu");
            int i = readerGridView.RowCount;
            readerGridView.CurrentCell = readerGridView[0, i - 1];
            txtReaderName.Focus();
            AddNewFlag = true;
            btnFunction.Visible = true;
            txtIDReader.Visible = false;
            labelReaderID.Visible = false;
            DeleteFlag = false;
            UpdateFlag = false;
            lblValidDate.Visible = false;
            txtValidDate.Visible = false;

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn ô muốn sửa, nhập thông tin và ấn cập nhật để sửa dữ liệu");
            AddNewFlag = false;
            btnFunction.Visible = true;
            DeleteFlag = false;
            UpdateFlag = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            readerGridView.CurrentCell = readerGridView[0, 0];

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int i = readerGridView.Rows.Count;
            readerGridView.CurrentCell = readerGridView[0, i - 1];
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int i = readerGridView.CurrentRow.Index;
            if (i == readerGridView.RowCount)
            {
                readerGridView.CurrentCell = readerGridView[0, 0];
            }
            else
            {
                readerGridView.CurrentCell = readerGridView[0, i + 1];

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int i = readerGridView.CurrentRow.Index;
            int n = readerGridView.Rows.Count;
            if (i == 0)
            {
                readerGridView.CurrentCell = readerGridView[0, n - 1];
            }
            else
            {
                readerGridView.CurrentCell = readerGridView[0, i - 1];

            }
        }

        private void ucFrmReader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {   if(comFields.Text == "ID độc giả") {
                string sql = "Select * From LibMngm.Readers"
    + " WHERE ReaderID  LIKE N'" + comFieldsValue.Text + "%'";
                Controller.DataProvider dataProvider = new Controller.DataProvider();
            readerGridView.DataSource = dataProvider.GetData(sql);
            loadDetails();
            }
            else
            {
                string sql = "Select * From LibMngm.Readers"
    + " WHERE ReaderName  LIKE N'" + comFieldsValue.Text + "%'";
                Controller.DataProvider dataProvider = new Controller.DataProvider();
                readerGridView.DataSource = dataProvider.GetData(sql);
                loadDetails();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportCard_Click(object sender, EventArgs e)
        {
            rptPhieuThongTinDocGia rpt = new rptPhieuThongTinDocGia();
            rpt.SetDataSource(readerController.ExportReaderCard(txtIDReader.Text));
            ReportForm.frmRprReaderCard frm = new ReportForm.frmRprReaderCard(rpt);
            frm.Show();
        }

        private void btnReportReader_Click(object sender, EventArgs e)
        {
            rptReaderList rpt = new rptReaderList();
            rpt.SetDataSource(readerController.LoadReader());
            ReportForm.frmRptReaderList frm = new ReportForm.frmRptReaderList(rpt);
            frm.Show();
        }

        private void lblValidDate_Click(object sender, EventArgs e)
        {

        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (AddNewFlag == true)
            {
                Model.Reader reader = new Model.Reader();
                reader.readerDOB = DateTime.ParseExact(txtReaderDOB.Text, "MM/dd/yyyy", null).ToString();
                reader.readerJob = txtReaderJob.Text;
                reader.readerName = txtReaderName.Text;
                reader.readerGender = txtReaderGender.Text;
                Controller.ReaderController readerController = new Controller.ReaderController();
                readerController.AddReader(reader);
                ucFrmReader_Load(sender, e);
                ResetGridView();
            } else if (UpdateFlag == true)
            {
                Model.Reader reader = new Model.Reader();
                reader.readerID = txtIDReader.Text;
                reader.readerDOB = DateTime.ParseExact(txtReaderDOB.Text, "MM/dd/yyyy", null).ToString();
                reader.readerJob = txtReaderJob.Text;
                reader.readerName = txtReaderName.Text;
                reader.readerGender = txtReaderGender.Text;
                Controller.ReaderController readerController = new Controller.ReaderController();
                readerController.UpdateReader(reader);
                ResetGridView();
                ucFrmReader_Load(sender, e);
            } else if(DeleteFlag == true)
            {
                if (txtIDReader != null)
                {
                    Controller.ReaderController readerController = new Controller.ReaderController();
                    readerController.DeleteReader(txtIDReader.Text);
                    ResetGridView();
                    ucFrmReader_Load(sender, e);
                }
            }
        }

        private void ResetGridView()
        {
            lblValidDate.Visible = true;
            labelReaderID.Visible = true;
            txtIDReader.Visible = true;
            lblValidDate.Visible = true;
            btnFunction.Visible = false;
            txtIDReader.Clear();
            txtReaderDOB.Clear();
            txtReaderGender.Clear();
            txtReaderJob.Clear();
            txtValidDate.Clear();
            txtReaderName.Clear();
        }
    }
}
