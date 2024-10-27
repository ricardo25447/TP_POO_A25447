using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Login
    {
        //atributes
        public string User_Login { get; set; }
        public string Password_Login { get; set; }

        public Login(string user_Login, string password_Login)
        {
            User_Login = user_Login;
            Password_Login = password_Login;
        }

        //authentication
        public bool AuthenticateAdmin()
        {
            return User_Login == "admin" && Password_Login == "password123";
        }
        public bool AuthenticateUser() 
        {
            return User_Login == "inquilino" && Password_Login == "password123";
        }
    }
    }
