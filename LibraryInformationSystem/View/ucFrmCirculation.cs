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
    public partial class ucFrmCirculation : UserControl
    {
        int i;
        public ucFrmCirculation()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void ucFrmCirculation_Load(object sender, EventArgs e)
        {
            Controller.CirculationController controller = new Controller.CirculationController();
            grdCirculation.DataSource= controller.LoadCard();
            
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadDetails()
        {
            i = grdCirculation.CurrentRow.Index;
            txtBookIDCir.Text = grdCirculation.Rows[i].Cells["BookID"].Value.ToString();
            txtCardID.Text = grdCirculation.Rows[i].Cells["CardID"].Value.ToString();
            txtStatus.Text = grdCirculation.Rows[i].Cells["Status"].Value.ToString();
            txtBorrowedDate.Text = grdCirculation.Rows[i].Cells["BorrowedDate"].Value.ToString();
            txtSupposedReturn.Text = grdCirculation.Rows[i].Cells["SupposedReturn"].Value.ToString();
            txtActualReturn.Text = grdCirculation.Rows[i].Cells["ActualReturn"].Value.ToString();
            txtNote.Text = grdCirculation.Rows[i].Cells["Note"].Value.ToString();
            txtReaderID.Text = grdCirculation.Rows[i].Cells["ReaderID"].Value.ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void grdCirculation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin nhập thông tin mượn sách mới");
            btnUpdate.Visible = true;
            lblCardID.Visible = false;
            txtCardID.Visible = false;
            txtActualReturn.Visible = false;
            lblActualReturn.Visible = false;
            i = grdCirculation.RowCount;
            grdCirculation.CurrentCell = grdCirculation[0, i - 1]; ;
            loadDetails();
            txtBookIDCir.Focus();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Model.Circulation circulation = new Model.Circulation();
            circulation.borrowedDate = DateTime.ParseExact(txtBorrowedDate.Text, "MM'/'dd'/'yyyy", null);
            circulation.bookID = txtBookIDCir.Text;
            circulation.readerID = txtReaderID.Text;
            circulation.supposedReturn = DateTime.ParseExact(txtSupposedReturn.Text, "MM'/'dd'/'yyyy", null);
            Controller.CirculationController circulationController = new Controller.CirculationController();
            circulationController.AddCard(circulation);
            ucFrmCirculation_Load(sender, e);
            ResetGridView();
        }

        private void ResetGridView()
        {
            btnUpdate.Visible = false;
            lblCardID.Visible = true;
            txtCardID.Visible = true;
            txtActualReturn.Visible = true;
            lblActualReturn.Visible = true; 
            txtReaderID.ResetText();
            txtCardID.ResetText();
            txtBorrowedDate.ResetText();
            txtBookIDCir.ResetText();
            txtActualReturn.ResetText();
            txtBorrowedDate.ResetText();
            txtStatus.ResetText();
            txtSupposedReturn.ResetText();

        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            extendGroup.Visible = true;

        }

        private void extendGroup_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirmExtend_Click(object sender, EventArgs e)
        {
            Controller.CirculationController circulation = new Controller.CirculationController();

            if (rb1Week.Checked == true)
            {
                circulation.Extend1Week(txtSupposedReturn.Text);
                MessageBox.Show("Đã gia hạn mượn sách thêm 1 tuần");
                extendGroup.Visible = false;

            }
            else if (rb2Week.Checked == true)
            {
                circulation.Extend2Week(txtSupposedReturn.Text);
                MessageBox.Show("Đã gia hạn mượn sách thêm 1 tuần");
                extendGroup.Visible = false;

            }
        }
    }
}
