using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicesDAL
    {

        DBConn dbcon = new DBConn();
        public bool ServicesInsertDAL(Services services)
        {
            string queryInsert = "INSERT INTO TServices VALUES('" + services.S_Name + "','" + services.S_Image + "','" + services.S_Price + "','" + services.S_Description + "')";
            return dbcon.ExecuteCommand(queryInsert);
        }

        public bool ServicesDeleteDAL(int SID)
        {

            string querydelete = " DELETE FROM TServices WHERE SID = '" + SID + "'";
            return dbcon.ExecuteCommand(querydelete);
        }
        public bool ServicesUpdateDAL(int SID, string SName, string SImage, string SPrice, string SDescription)
        {

            string queryupdate = " UPDATE  TServices SET SName = '" + SName + "', SImage ='" + SImage + "',SPrice = '" + SPrice + "', SDescription = '" + SDescription + "'  WHERE SID = '" + SID + "'";
            return dbcon.ExecuteCommand(queryupdate);
        }

        public DataTable ServicesSearchDAL(int SID)
        {
            string queryselect = "SELECT * FROM TServices WHERE SID = '" + SID + "'";
            return dbcon.FetchData(queryselect);
        }

        public DataTable ServicesSearchAllDAL()
        {
            string queryselect = "SELECT * FROM TServices";
            return dbcon.FetchData(queryselect);
        }


    }
}
