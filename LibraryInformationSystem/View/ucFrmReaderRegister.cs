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
    public partial class ucFrmReaderRegister : UserControl
    {
        public ucFrmReaderRegister()
        {
            InitializeComponent();
        }

        private void btnSignUpUser_Click(object sender, EventArgs e)
        {
            Model.Reader reader = new Model.Reader();
            reader.readerName = txtReaderName.Text;
            reader.readerDOB = txtReaderDOB.Text;
            reader.readerJob = txtReaderOccupation.Text;
        }
    }
}
