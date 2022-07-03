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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { string connstr = "Data Source=MSI;Initial Catalog=LibraryMng;Integrated Security=True";
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            SqlCommand loginCmd = new SqlCommand("Select UserName, Password from LibMngm.Users where UserName='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'", con);
            SqlDataAdapter loginAdapter = new SqlDataAdapter(loginCmd);
            DataTable loginDt = new DataTable();
            loginAdapter.Fill(loginDt);

            if (loginDt.Rows.Count > 0)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, xin kiểm tra lại");
            }
            con.Close();
        }
    }
}
