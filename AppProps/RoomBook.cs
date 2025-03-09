using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class RoomBook
    {
        private int uhbId;
        private int UID;
        private string uhbRoomType;
        private DateTime uhbDate;
        private decimal uhbPrice;
        private int uhbDuration;
        private string uhbRemarks;
        public int UhbId { get => uhbId; set => uhbId = value; }
        public string UhbRoomType { get => uhbRoomType; set => uhbRoomType = value; }
        public DateTime UhbDate { get => uhbDate; set => uhbDate = value; }
        public decimal UhbPrice { get => uhbPrice; set => uhbPrice = value; }
        public int UhbDuration { get => uhbDuration; set => uhbDuration = value; }
        public string UhbRemarks { get => uhbRemarks; set => uhbRemarks = value; }
        public int UID1 { get => UID; set => UID = value; }
    }
}
