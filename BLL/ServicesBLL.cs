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
    public class ServicesBLL
    {

        ServicesDAL servicesDal = new ServicesDAL();

        public bool ServicesInsertBLL(Services service)
        {
            return servicesDal.ServicesInsertDAL(service);
        }

        public bool ServicesDeleteBLL(int SID)
        {
            return servicesDal.ServicesDeleteDAL(SID);
        }

        public bool ServicesUpdateBLL(int SID, string SName, string SImage, string SPrice, string SDescription)
        {
            return servicesDal.ServicesUpdateDAL(SID, SName, SImage, SPrice, SDescription);
        }
        public DataTable ServicesSearchBLL(int SID)
        {
            return servicesDal.ServicesSearchDAL(SID);
        }

        public DataTable ServicesSearchAllBLL()
        {
            return servicesDal.ServicesSearchAllDAL();
        }

        public bool ServicesUpdateBLL(Services updatedService)
        {
            throw new NotImplementedException();
        }

        public List<Services> ServiceSearchUBLL()
        {
            DataTable dt = servicesDal.ServicesSearchAllDAL();
            List<Services> services = new List<Services>();
            foreach (DataRow row in dt.Rows)
            {
                Services ser = new Services
                {
                    S_ID = Convert.ToInt32(row["SID"]),
                    S_Name = row["SName"].ToString(),
                    S_Image = row["SImage"].ToString(),
                    S_Price = row["SPrice"].ToString(),
                    S_Description = row["SDescription"].ToString()
                };
                services.Add(ser);
            }
            return services;
        }

    }

}
