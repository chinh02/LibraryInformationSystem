using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace LibraryInformationSystem
{
    public partial class frmMain : Form
    {




        public frmMain()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {




        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.ucFrmReader ucFrmReader = new View.ucFrmReader();
            ucFrmReader.Dock = DockStyle.Fill;
            this.Controls.Add(ucFrmReader);
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.ucFrmBooks ucFrmBooks = new View.ucFrmBooks();
            ucFrmBooks.Dock = DockStyle.Fill;
            this.Controls.Add(ucFrmBooks);
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.ucFrmAuthor ucFrmAuthor = new View.ucFrmAuthor();
            ucFrmAuthor.Dock = DockStyle.Fill;
            this.Controls.Add(ucFrmAuthor);
        }

        private void quảnLýMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.ucFrmCirculation ucFrmCirculation = new View.ucFrmCirculation();
            ucFrmCirculation.Dock = DockStyle.Fill;
            this.Controls.Add(ucFrmCirculation);

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.ucFrmBooks ucFrmBooks = new View.ucFrmBooks();
            addUserControl(ucFrmBooks);
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            View.ucFrmReader ucFrmReader = new View.ucFrmReader();
            addUserControl(ucFrmReader);
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            View.ucFrmAuthor ucFrmAuthor = new View.ucFrmAuthor();
            addUserControl(ucFrmAuthor);
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            View.ucFrmCirculation ucFrmCirculation = new View.ucFrmCirculation();
            addUserControl(ucFrmCirculation);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
