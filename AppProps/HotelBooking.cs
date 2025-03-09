using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class HotelBooking
    {
        private int HB_id;
        private string HB_room;
        private string HB_date;
        private string HB_price;
        private string HB_duratuon;

        public int UHB_id { get => HB_id; set => HB_id = value; }
        public string UHB_room { get => HB_room; set => HB_room = value; }
        public string UHB_date { get => HB_date; set => HB_date = value; }
        public string UHB_price { get => HB_price; set => HB_price = value; }
        public string UHB_duration { get => HB_duratuon; set => HB_duratuon = value; }
    }
}
