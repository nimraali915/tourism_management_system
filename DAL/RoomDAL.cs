using AppProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomDAL
    {
        DBConn dbcon = new DBConn();
        public bool RoomInsertDAL(RoomBook rb)
        {
            string queryInsert = "INSERT INTO UHotelBook VALUES('" + rb.UhbRoomType + "','" + rb.UhbDate + "','" + rb.UhbPrice + "', '" + rb.UhbDuration + "','" + rb.UhbRemarks + "', '"+rb.UID1+"')";

            return dbcon.ExecuteCommand(queryInsert);
        }
    }
}
