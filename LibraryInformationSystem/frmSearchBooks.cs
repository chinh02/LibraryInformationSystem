using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryInformationSystem
{
    public partial class frmSearchBooks : Form
       
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        String SQL, constr;
        int i;

        public frmSearchBooks()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)


        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL = "select BookID, Title, Author,Genre, Publisher From LibMngm.Books where " + comkeyword.Text+" like" + " N'%" + txtsearch.Text + "%'";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
        }

        private void documentTableBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void frmSearchBooks_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BFJ9N2U\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            SQL = "Select BookID,Title,Author,Genre,Publisher from LibMngm.Books";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQL = "Select Distinct " + comtentruong.Text + "  From LibMngm.Books";
            da = new SqlDataAdapter(SQL, conn);
            comdt.Clear();
            da.Fill(comdt);
            comgt.DataSource = comdt;
            comgt.DisplayMember = comtentruong.Text;
        }

        private void comgt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            SQL = "Select Title,Author,Genre,Publisher from LibMngm.Books" + " where " + comtentruong.Text + " = N'" + comgt.Text + "'";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            NapCT();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQL = "Select BookID,Title,Author,Genre,Publisher from LibMngm.Books";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            NapCT();
        }

        private void NapCT()
        {
            i = grddata.CurrentRow.Index;
            txtTitle.Text = grddata.Rows[i].Cells["Title"].Value.ToString();
            txtAuthor.Text = grddata.Rows[i].Cells["Author"].Value.ToString();
            txtGenre.Text = grddata.Rows[i].Cells["Genre"].Value.ToString();
            txtPublisher.Text = grddata.Rows[i].Cells["Publisher"].Value.ToString();
        }
    }
}
