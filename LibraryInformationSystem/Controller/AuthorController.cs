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
            string sql = string.Format("INSERT INTO LibMngm.Authors values ('{0}','{1}')", Author.authorName, Author.authorYOB);

            if (GetData("SELECT * FROM LibMngm.Authors WHERE AuthorID = '" + Author.authorID + "'").Rows.Count == 0)
                Execute(sql);
        }
        public void UpdateAuthor(Model.Author Author)
        {
            string sql = string.Format("UPDATE LibMngm.Authors SET AuthorName = N'{0}', AuthorYOB = N'{1}' where AuthorID = '{3}'",
            Author.authorName, Author.authorYOB, Author.authorID);
            Execute(sql);
        }
    }
}
