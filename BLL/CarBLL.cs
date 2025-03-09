using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CarBLL
    {
        CarDAL carDAL = new CarDAL();
        public bool CarInsertBLL(CarBook car)
        {

            return carDAL.CarInsertDAL(car);
        }
       
    }
}
