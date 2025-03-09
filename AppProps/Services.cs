using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Services
    {
        private int SID;
        private string SName;
        private string SImage;
        private string SPrice;
        private string SDescription;

        public int S_ID { get => SID; set => SID = value; }
        public string S_Name { get => SName; set => SName = value; }
      
        public string S_Price { get => SPrice; set => SPrice = value; }
        public string S_Description { get => SDescription; set => SDescription = value; }
      
        public string S_Image{ get => SImage; set => SImage = value; }
    }
}
