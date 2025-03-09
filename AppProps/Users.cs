using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Users
    {
        private int ID;
        private string Name;
        private string Email;
        private string Password;
        private string Contact;
        private int AccessLevel;
        public int UID { get => ID; set => ID = value; }
        public string UName { get => Name; set => Name = value; }
        public string UEmail { get => Email; set => Email = value; }
        public string UPassword { get => Password; set => Password = value; }
        public string UContact { get => Contact; set => Contact = value; }
        public int UAccessLevel { get => AccessLevel; set => AccessLevel = value; }
    }
}
