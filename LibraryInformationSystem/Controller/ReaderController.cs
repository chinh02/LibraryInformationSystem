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
            Execute(sql);

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
            Execute(sqlString);
        }
        public void AddReader (Model.Reader reader)
        {
            string sql = string.Format("INSERT INTO LibMngm.Readers values ('{0}','{1}','{2}','{3}','{4}')",reader.readerName, reader.validDate, reader.readerJob, reader.readerDOB, reader.expiredDate);

            if (GetData("SELECT * FROM LibMngm.Readers WHERE ReaderId = '" + reader.readerID + "'").Rows.Count == 0)
            Execute(sql);
        }
        public void UpdateReader (Model.Reader reader)
        {
            string sql = string.Format("UPDATE LibMngm.Readers SET ReaderName = N'{0}', ReaderJob = N'{1}', ReaderDOB = '{2}', ValidDate = N'{3}', ExpiredDate ='{4}' where ReaderID = '{5}'",
            reader.readerName, reader.readerJob, reader.readerDOB, reader.validDate, reader.expiredDate, reader.readerID);
            Execute(sql);
        }
    }
}
