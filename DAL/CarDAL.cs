using AppProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarDAL
    {
        DBConn dbcon = new DBConn();
        public bool CarInsertDAL(CarBook cb)
        {
            string queryInsert = "INSERT INTO cBooking VALUES('" + cb.CDestinataion1 + "','" + cb.CFrom1 + "','" + cb.CDate1 + "', '" + cb.Remarks1 + "','"+cb.UID1+"')";
            return dbcon.ExecuteCommand(queryInsert);
        }
    }
}
