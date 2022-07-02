using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInformationSystem.Model
{
    class Circulation
    {   
        public string cardID { get; set; }
        public string readerID { get; set; }
        public string bookID { get; set; }
        public string borrowedDate { get; set; }
        public string status { get; set; }
        public string supposedReturn { get; set; }
        public DateTime actualReturn { get; set; }
        public string note { get; set; }

    }
}
