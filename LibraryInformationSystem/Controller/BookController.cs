using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace LibraryInformationSystem.Controller
{
    class BookController:DataProvider
    {
        public DataTable LoadBook()
        {
            string sqlString = @"Select * From LibMngm.Books";
            return GetData(sqlString);
        }
        public void DeleteBook(string BookID)
        {
            string sqlString = @"DELETE FROM LibMngm.Books Where BookID = '" + BookID + "'";
            Execute(sqlString);
        }
        public void AddBook(Model.Book Book)
        {
            string sql = string.Format("INSERT INTO LibMngm.Books (Title, Author, Genre, Publisher) values ('{0}','{1}','{2}','{3}')", Book.bookTitle, Book.bookAuthor, Book.bookGenre, Book.bookPublisher);

            if (GetData("SELECT * FROM LibMngm.Books WHERE BookId = '" + Book.bookID + "'").Rows.Count == 0)
                Execute(sql);
        }
        public void UpdateBook(Model.Book Book)
        {
            string sql = string.Format("UPDATE LibMngm.Books SET Title = N'{0}', Author = N'{1}', Genre = '{2}', Publisher = N'{3}' where BookID = '{5}'",
            Book.bookTitle, Book.bookAuthor, Book.bookGenre, Book.bookPublisher, Book.bookID);
            Execute(sql);
        }
    }
}
