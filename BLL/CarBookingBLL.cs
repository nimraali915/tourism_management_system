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
    public class CarBookingBLL
    {
        CarBookingDAL CB_DAL = new CarBookingDAL();

        public bool CarBookingInsertBLL(CarBooking CB)
        {
            return CB_DAL.CarBookingInsertDAL(CB);
        }

        public bool CarBookingDeleteBLL(int ID)
        {
            return CB_DAL.CarBookingDeleteDAL(ID);
        }

        public bool CarBookingUpdateBLL(int cID, string Destination, string From, string Date, string description)
        {
            return CB_DAL.CarBookingUpdateDAL(cID,Destination,From,Date,description);
        }
        public DataTable CarBookingSearchBLL(int ID)
        {
            return CB_DAL.CarBookingSearchDAL(ID);
        }

        public DataTable CarBookingSearchAllBLL()
        {
            return CB_DAL.CarBookingSearchAllDAL();
        }
    }
}
