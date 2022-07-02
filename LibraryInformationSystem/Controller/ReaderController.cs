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
            string sql = string.Format("INSERT INTO LibMngm.Readers values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",reader.readerName, reader.readerGender, reader.readerDOB, reader.readerJob, reader.validDate);

            if (GetData("SELECT * FROM LibMngm.Readers WHERE ReaderId = '" + reader.readerID + "'").Rows.Count == 0)
            Execute(sql);
        }
        public void UpdateReader (Model.Reader reader)
        {
            string sql = string.Format("UPDATE LibMngm.Readers SET ReaderName = N'{0}', ReaderJob = N'{1}', ReaderDOB = '{2}', ValidDate = N'{3}', Gender ='{4}' where ReaderID = '{5}'",
            reader.readerName, reader.readerJob, reader.readerDOB, reader.validDate, reader.readerGender, reader.readerID);
            Execute(sql);
        }
    }
}
