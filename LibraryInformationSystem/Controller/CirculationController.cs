using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LibraryInformationSystem.Controller
{
    class CirculationController : DataProvider
    {
        public DataTable LoadCard()
        {
            string sqlString = @"Select * From LibMngm.Circulations";
            return GetData(sqlString);
        }
        public void DeleteCard(string cardID)
        {
            string sqlString = @"DELETE FROM LibMngm.Circulations Where CardID = '" + cardID + "'";
            Execute(sqlString);
        }
        public void AddCard(Model.Circulation circulation)
        {
            string sql = string.Format("INSERT INTO LibMngm.Circulations (ReaderID, BookID, BorrowedDate, SupposedReturn, Status, Note) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , circulation.readerID, circulation.bookID ,circulation.borrowedDate, circulation.supposedReturn, circulation.status, circulation.note);

                Execute(sql);
        }
        public void UpdateCard(Model.Circulation circulation)
        {
            string sql = string.Format("UPDATE LibMngm.Circulations SET ReaderID = N'{0}', BookID = N'{1}', BorrowedDate = '{2}', ActualReturn = N'{3}', Status = N'{4}', Note =N'{5}' where CardID = '{6}'",
            circulation.readerID, circulation.bookID, circulation.borrowedDate, circulation.supposedReturn, circulation.actualReturn, circulation.status, circulation.note, circulation.cardID);
            Execute(sql);
        }
        public void Extend1Week(string cardID)
        {
            string sql = @"UPDATE LibMngm.Circulations SET SupposedReturn = DATEADD(week,1,SupposedReturn) WHERE CardID = '"+cardID+"'";
            Execute(sql);
        }
        public void Extend2Week(string cardID)
        {
            string sql = @"UPDATE LibMngm.Circulations SET SupposedReturn = DATEADD(week,2,SupposedReturn) WHERE CardID = '" + cardID+"'";
            Execute(sql);
        }

    }
}
