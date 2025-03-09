using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class CarBook
    {
        private int CID;
        private int UID;
        private string CDestinataion;
        private string CFrom;
        private DateTime CDate;
        private string Remarks;

        public int CID1 { get => CID; set => CID = value; }
        public string CDestinataion1 { get => CDestinataion; set => CDestinataion = value; }
        public string CFrom1 { get => CFrom; set => CFrom = value; }
        public DateTime CDate1 { get => CDate; set => CDate = value; }
        public string Remarks1 { get => Remarks; set => Remarks = value; }
        public int UID1 { get => UID; set => UID = value; }
    }
}
