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
    public class LoginBLL
    {
        LoginDAL logindal = new DAL.LoginDAL();
        public DataTable LoginSearchBLL(Login l)
        {
            return logindal.LoginSearchDAL(l);
        }

    }
}
