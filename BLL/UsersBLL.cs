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
    public class UsersBLL
    {
        UsersDAL userDal = new UsersDAL();

        public bool UserInsertBLL(Users user)
        {
            return userDal.UsersInsertDAL(user);
        }

        public bool UserDeleteBLL(string UserId)
        {
            return userDal.UsersDeleteDAL(UserId);
        }

        public bool UserUpdateBLL(int UserID, string UName, string UEmail, string UPassword, string UContact, int UAccessLevel)
        {
            return userDal.UsersUpdateDAL(UserID, UName, UEmail, UPassword, UContact, UAccessLevel);
        }
        public DataTable UserSearchBLL(string UserId)
        {
            return userDal.UsersSearchDAL(UserId);
        }

        public DataTable UserSearchAllBLL()
        {
            return userDal.UsersSearchAllDAL();
        }

    }
}
