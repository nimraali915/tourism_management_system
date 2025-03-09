using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDAL
    {

        DBConn dbcon = new DBConn();
        public bool UsersInsertDAL(Users user)
        {
            string queryInsert = "INSERT INTO Users VALUES('" + user.UName + "','" + user.UEmail + "','" + user.UPassword + "','" + user.UContact + "','" + user.UAccessLevel + "')";
            return dbcon.ExecuteCommand(queryInsert);
        }

        public bool UsersDeleteDAL(string UserID)
        {

            string querydelete = " DELETE FROM Users WHERE UID = '" + UserID + "'";
            return dbcon.ExecuteCommand(querydelete);
        }
        public bool UsersUpdateDAL(int UserID, string UName, string UEmail, string UPassword, string UContact, int UAccessLevel)
        {

            string queryupdate = " UPDATE  Users SET UName = '" + UName + "', UEmail ='" + UEmail + "',UPassword = '" + UPassword + "', UContact = '" + UContact + "', UAccessLevel ='"+ UAccessLevel+"'  WHERE UID = '" + UserID + "'";
            return dbcon.ExecuteCommand(queryupdate);
        }

        public DataTable UsersSearchDAL(string UserID)
        {
            string queryselect = "SELECT * FROM Users WHERE UID = '" + UserID + "'";
            return dbcon.FetchData(queryselect);
        }

        public DataTable UsersSearchAllDAL()
        {
            string queryselect = "SELECT * FROM Users";
            return dbcon.FetchData(queryselect);
        }
    }
}
