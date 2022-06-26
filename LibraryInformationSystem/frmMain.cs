using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryInformationSystem.Forms
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
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

        private void lịchSửTruyCậpToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void quảnLýQuyềnTruyCậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýQuyềnTruyCậpToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
