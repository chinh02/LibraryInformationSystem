using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInformationSystem.Controller
{
    class AuthorController:DataProvider
    {
        public DataTable LoadAuthor()
        {
            string sqlString = @"Select * From LibMngm.Authors";
            return GetData(sqlString);
        }
        public void DeleteAuthor(string AuthorID)
        {
            string sqlString = @"DELETE FROM LibMngm.Authors Where AuthorID = '" + AuthorID + "'";
            Execute(sqlString);
        }
        public void AddAuthor(Model.Author Author)
        {
            string sql = string.Format("INSERT INTO LibMngm.Authors values (N'{0}',N'{1}')", Author.authorName, Author.authorYOB);

                Execute(sql);
        }
        public void UpdateAuthor(Model.Author Author)
        {
            string sql = string.Format("UPDATE LibMngm.Authors SET AuthorName = N'{0}', YOB = N'{1}' where AuthorID = '{2}'",
            Author.authorName, Author.authorYOB, Author.authorID);
            Execute(sql);
        }
    }
}
