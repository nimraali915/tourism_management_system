using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DestinationBLL
    {
        DestinationDAL DestinationDal = new DestinationDAL();

        public bool DestinationInsertBLL(Destination d)
        {
            return DestinationDal.DestinationInsertDAL(d);
        }

        public bool DestinationDeleteBLL(int DID)
        {
            return DestinationDal.DestinationDeleteDAL(DID);
        }

        public bool DestinationUpdateBLL(int dID, string Dname, string DImage, string DDescription)
        {
            return DestinationDal.DestinationUpdateDAL(dID, Dname, DImage, DDescription);
        }
        public DataTable DestinationSearchBLL(int DID)
        {
            return DestinationDal.DestinationSearchDAL(DID);
        }

        public DataTable DestinationSearchAllBLL()
        {
            return DestinationDal.DestinationSearchAllDAL();
        }

       
        public List<Destination> DestinationSearchUBLL()
        {
            DataTable dt = DestinationDal.DestinationSearchAllDAL();
            List<Destination> destinations = new List<Destination>();
            foreach (DataRow row in dt.Rows)
            {
                Destination destination = new Destination
                {
                    Did = Convert.ToInt32(row["DID"]),
                    Ddame = row["DName"].ToString(),
                    Dimage = row["DImage"].ToString(),
                    Ddescription = row["DDescription"].ToString()
                };
                destinations.Add(destination);
            }
            return destinations;
        }

    }
}
