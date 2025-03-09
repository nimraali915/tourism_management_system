using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HotelBookingDAL
    {

        DBConn dbcon = new DBConn();
        public bool HotelBookInsertDAL(HotelBooking HB)
        {
            string queryInsert = "INSERT INTO UHotelBook VALUES('" + HB.UHB_room + "','" +HB.UHB_date + "','" + HB.UHB_price + "','" + HB.UHB_duration + "')";
            return dbcon.ExecuteCommand(queryInsert);
        }

        public bool HotelBookDeleteDAL(int HB_ID)
        {

            string querydelete = " DELETE FROM UHotelBook WHERE UHB_ID = '" + HB_ID + "'";
            return dbcon.ExecuteCommand(querydelete);
        }
        public bool HotelBookUpdateDAL(int HB_ID, string RoomType, string Date, string Price, string Duration)
        {

            string queryupdate = " UPDATE UHotelBook SET UHB_RoomType = '" + RoomType + "', UHBDate ='" + Date + "',UHB_Price = '" + Price + "', UHB_Duration = '" + Duration + "'  WHERE UHB_ID = '" + HB_ID + "'";
            return dbcon.ExecuteCommand(queryupdate);
        }

        public DataTable HotelBookSearchDAL(int HB_ID)
        {
            string queryselect = "SELECT * FROM UHotelBook WHERE UHB_ID = '" + HB_ID + "'";
            return dbcon.FetchData(queryselect);
        }

        public DataTable HotelBookSearchAllDAL()
        {
            string queryselect = "SELECT * FROM UHotelBook";
            return dbcon.FetchData(queryselect);
        }
    }
}
