using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryInformationSystem
{
    public partial class frmSearchBooks : Form
    {
        public frmSearchBooks()
        {
            InitializeComponent();
        }

        string SQL;
        static string conn = "Data Source=MSI;Initial Catalog=LibraryMng;Integrated Security=True";
        DataTable dt;
        SqlDataAdapter da;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comFields.SelectedItem == null)
            {
                SQL = "select BookID, Title, Author,Genre, Publisher From LibMngm.Books where  Title  like " + " N'%" + txtSearch.Text + "%' or Author like " +
                     " N'%" + txtSearch.Text + "%' or Genre like " + " N'%" + txtSearch.Text + "%' or Publisher like " + " N'%" + txtSearch.Text + "%'";

            }
            else if (comFields.Text == "Nhan đề")
            {
                SQL = "select BookID, Title, Author,Genre, Publisher From LibMngm.Books where Title like" + " N'%" + txtSearch.Text + "%'";
            } else if(comFields.Text =="Tác giả")
            {
                SQL = "select BookID, Title, Author,Genre, Publisher From LibMngm.Books where Author like" + " N'%" + txtSearch.Text + "%'";
            } else if (comFields.Text =="Thể loại")
            {
                SQL = "select BookID, Title, Author,Genre, Publisher From LibMngm.Books where Genre like" + " N'%" + txtSearch.Text + "%'";
            }
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void documentTableBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void comFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
