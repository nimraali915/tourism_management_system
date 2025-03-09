using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Login
    {
        private string Email;
        private string Password;

        public string UEmail { get => Email; set => Email = value; }
        public string UPassword { get => Password; set => Password = value; }
    }
}
