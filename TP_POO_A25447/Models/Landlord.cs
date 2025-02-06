using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447.Models
{
    public class Landlord
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CC { get; set; }

        public Landlord(string username, string password, string cc)
        {
            Username = username;
            Password = password;
            CC = cc;
        }
    }
}





