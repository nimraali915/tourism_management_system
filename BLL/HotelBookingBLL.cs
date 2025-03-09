using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HotelBookingBLL
    {


        HotelBookingDAL HB_Dal = new HotelBookingDAL();

        public bool HotelBookInsertBLL(HotelBooking HB)
        {
            return HB_Dal.HotelBookInsertDAL(HB);
        }

        public bool HotelBookDeleteBLL(int HBID)
        {
            return HB_Dal.HotelBookDeleteDAL(HBID);
        }

        public bool HotelBookUpdateBLL(int HB_ID, string RoomType, string Date, string Price, string Duration)
        {
            return HB_Dal.HotelBookUpdateDAL(HB_ID, RoomType, Date, Price, Duration);
        }
        public DataTable HotelBookSearchBLL(int HBID)
        {
            return HB_Dal.HotelBookSearchDAL(HBID);
        }

        public DataTable HotelBookSearchAllBLL()
        {
            return HB_Dal.HotelBookSearchAllDAL();
        }
    }
}
