using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class CarBooking
    {
        private int CID;
        private string CDestination;
        private string CFrom;
        private string CDate;
        private string CDescription;

        public int Cid { get => CID; set => CID = value; }
        public string C_Destination { get => CDestination; set => CDestination = value; }
        public string C_From { get => CFrom; set => CFrom = value; }
        public string C_Date { get => CDate; set => CDate = value; }
        public string C_Description { get => CDescription; set => CDescription = value; }
    }
}
