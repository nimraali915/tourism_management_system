using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarBookingDAL
    {
        DBConn dbcon = new DBConn();
        public bool CarBookingInsertDAL(CarBooking CB)
        {
            string queryInsert = "INSERT INTO  cBooking VALUES('" + CB.C_Destination + "','" + CB.C_From + "','" + CB.C_Date + "', '"+CB.C_Description +"')";
            return dbcon.ExecuteCommand(queryInsert);
        }

        public bool CarBookingDeleteDAL(int ID)
        {

            string querydelete = " DELETE FROM cBooking WHERE CID = '" + ID + "'";
            return dbcon.ExecuteCommand(querydelete);
        }
        public bool CarBookingUpdateDAL(int cID, string Destination, string From, string Date, string description)
        {

            string queryupdate = " UPDATE cBooking SET CDestinataion = '" + Destination + "', CFrom ='" + From + "',CDate = '" + Date + "', CDescription ='"+ description+"' WHERE CID = '" + cID + "'";
            return dbcon.ExecuteCommand(queryupdate);
        }

        public DataTable CarBookingSearchDAL(int ID)
        {
            string queryselect = "SELECT * FROM cBooking WHERE CID = '" + ID + "'";
            return dbcon.FetchData(queryselect);
        }

        public DataTable CarBookingSearchAllDAL()
        {
            string queryselect = "SELECT * FROM cBooking";
            return dbcon.FetchData(queryselect);
        }
    }
}
