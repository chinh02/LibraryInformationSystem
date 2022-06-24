using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInformationSystem.Controller
{
    class ReaderController:DataProvider
    {
        public bool signup(Model.Reader reader)
        {
            if (GetData("select* from Reader where ReaderName = '" + reader.readerName + "'").Rows.Count > 0)
                return false;
            Random rdm = new Random();
            reader.readerID = rdm.Next(0, 1000).ToString();
            while (GetData("select* from Reader where readerID = '" + reader.readerID + "'").Rows.Count > 0)
            {
                reader.readerID = rdm.Next(0, 1000).ToString();
            }
            string sql = string.Format("Insert Into Reader values('{0}','{1}','{2}','{3}')",
                 reader.readerID, reader.readerName, reader.readerJob, reader.readerDOB);
            Excute(sql);

            return true;
        }
        public DataTable LoadReader()
        {
            string sqlString = @"Select * From LibMngm.Readers";
            return GetData(sqlString);
        }
        public void DeleteReader(string readerID)
        {
            string sqlString = @"DELETE FROM LibMngm.Readers Where ReaderID = '" + readerID + "'";
            Excute(sqlString);
        }
    }
}
