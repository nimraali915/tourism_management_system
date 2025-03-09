using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Destination
    {
        private int DID;
        private string DName;
        private string DImage;
        private string DDescription;

        public int Did { get => DID; set => DID = value; }
        public string Ddame { get => DName; set => DName = value; }
        public string Dimage { get => DImage; set => DImage = value; }
        public string Ddescription { get => DDescription; set => DDescription = value; }
    }
}
