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
        {   
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSI;Initial Catalog=QLTV;Integrated Security=True";
            con.Open();
            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;
            SqlCommand loginCmd = new SqlCommand("Select UserName, UserPassword from UserTable where UserName='" + txtUserName.Text + "'and UserPassword='" + txtPassword.Text + "'", con);
            SqlDataAdapter loginAdapter = new SqlDataAdapter(loginCmd);
            DataTable loginDt = new DataTable();
            loginAdapter.Fill(loginDt);
            if(loginDt.Rows.Count > 0)
            {
                MessageBox.Show("Đúng");

            }
            else 
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, xin kiểm tra lại");
            }
            con.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
    }
}
