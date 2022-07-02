using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInformationSystem.Model
{
    class Reader
    {
        public string readerID { get; set; }
        public string readerName { get; set; }
        public DateTime readerDOB { get; set; }
        public string readerJob { get; set; }
        public DateTime validDate { get; set; }
        public DateTime expiredDate { get; set; }

    }
}
