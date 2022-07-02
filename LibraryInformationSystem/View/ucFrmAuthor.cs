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
        public ucFrmAuthor()
        {
            InitializeComponent();
        }

        private void ucFrmAuthor_Load(object sender, EventArgs e)
        {
            Controller.AuthorController authorController = new Controller.AuthorController();
            grdAuthor.DataSource = authorController.LoadAuthor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
