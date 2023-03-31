using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Infoshare.HandsOn.OOP
{
    public class Registration
    {

        public string _username;
        public string _password;

        public Registration(string username, string password)
        {
            _username = username;

            _password = password;

        }


        public static List<DateTime> Registrations = new List<DateTime>();

        public void Register()
        {
            Registrations.Add(DateTime.Now);

        }

    }
}
