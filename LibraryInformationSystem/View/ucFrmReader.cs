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
        
        public ucFrmReader()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucFrmReader_Load(object sender, EventArgs e)
        {
            Controller.ReaderController readerController = new Controller.ReaderController();
            
            readerGridView.DataSource = readerController.LoadReader();
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
            txtExpiredDate.Text = readerGridView.Rows[i].Cells["ExpiredDate"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtIDReader != null)
            {
                Controller.ReaderController readerController = new Controller.ReaderController();
                readerController.DeleteReader(txtIDReader.Text);
                ResetGridView();
                ucFrmReader_Load(sender, e);
            }
        }
        private void ResetGridView()
        {
            txtIDReader.ResetText();
            txtReaderName.ResetText();
            txtReaderDOB.ResetText();
            txtReaderJob.ResetText();
            txtValidDate.ResetText();
            txtExpiredDate.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Reader reader = new Model.Reader();
            reader.readerDOB = DateTime.ParseExact(txtReaderDOB.Text, "MM'/'dd'/'yyyy",null);
            reader.readerJob = txtReaderJob.Text;
            reader.readerName = txtReaderName.Text;
            reader.validDate = DateTime.ParseExact(txtValidDate.Text, "MM'/'dd'/'yyyy", null);
            reader.expiredDate = DateTime.ParseExact(txtExpiredDate.Text, "MM'/'dd'/'yyyy", null);
            Controller.ReaderController readerController = new Controller.ReaderController();
            readerController.AddReader(reader);
            ucFrmReader_Load(sender, e);
            ResetGridView();

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model.Reader reader = new Model.Reader();
            Random random = new Random();
            reader.readerDOB = DateTime.ParseExact(txtReaderDOB.Text, "MM'/'dd'/'yyyy", null);
            reader.readerJob = txtReaderJob.Text;
            reader.readerName = txtReaderName.Text;
            reader.validDate = DateTime.ParseExact(txtValidDate.Text, "MM'/'dd'/'yyyy", null);
            reader.expiredDate = DateTime.ParseExact(txtExpiredDate.Text, "MM'/'dd'/'yyyy", null);
            Controller.ReaderController readerController = new Controller.ReaderController();
            readerController.UpdateReader(reader);
            ucFrmReader_Load(sender, e);
            ResetGridView();
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
