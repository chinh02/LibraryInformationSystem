using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace LibraryInformationSystem.Controller
{
    class DataProvider
    {
        static string connstr = "Data Source=MSI;Initial Catalog=LibraryMng;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connstr);
        public DataTable GetData(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            dataTable.Clear();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public void Excute(string sql)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

}
