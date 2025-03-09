using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        DBConn dbcon = new DBConn();
        public DataTable LoginSearchDAL(Login l)
        {
            string queryselect = "SELECT * FROM Users WHERE UEmail = '" + l.UEmail + "' AND UPassword = '" + l.UPassword + "'";
            return dbcon.FetchData(queryselect);
        }
    }
}
