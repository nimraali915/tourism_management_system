using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DestinationDAL
    {
        DBConn dbcon = new DBConn();
        public bool DestinationInsertDAL(Destination des)
        {
            string queryInsert = "INSERT INTO  Destination VALUES('" + des.Ddame + "','" + des.Dimage + "','" + des.Ddescription + "')";
            return dbcon.ExecuteCommand(queryInsert);
        }

        public bool DestinationDeleteDAL(int DID)
        {

            string querydelete = " DELETE FROM Destination WHERE DID = '" + DID + "'";
            return dbcon.ExecuteCommand(querydelete);
        }
        public bool DestinationUpdateDAL(int dID, string Dname, string DImage, string DDescription)
        {

            string queryupdate = " UPDATE Destination SET DName = '" + Dname + "', DImage ='" + DImage + "',DDescription = '" + DDescription + "' WHERE DID = '" + dID + "'";
            return dbcon.ExecuteCommand(queryupdate);
        }

        public DataTable DestinationSearchDAL(int DID)
        {
            string queryselect = "SELECT * FROM Destination WHERE DID = '" + DID + "'";
            return dbcon.FetchData(queryselect);
        }

        public DataTable DestinationSearchAllDAL()
        {
            string queryselect = "SELECT * FROM Destination";
            return dbcon.FetchData(queryselect);
        }
    }
}

