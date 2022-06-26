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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
