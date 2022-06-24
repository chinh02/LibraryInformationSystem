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

            
        }
    }
}
