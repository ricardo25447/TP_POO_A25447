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
        public string User_CC { get; set; }

        public static string LoggedInUsername { get; private set; }
        public static string LoggedInCC { get; private set; }

        public Login(string user_Login, string password_Login, string user_cc)
        {
            User_Login = user_Login;
            Password_Login = password_Login;
            User_CC = user_cc;
        }

        //authentication
        public bool AuthenticateAdmin()
        {
            string landlordPath = @"C:\TP_POO_A25447\landlord.txt"; // file path

            if (File.Exists(landlordPath))
            {
                var Line = File.ReadAllLines(landlordPath); // read all lines in the txt

                foreach (var line in Line)
                {
                    // separate user, pw & cc with ","
                    var separate = line.Split(',');
                    if (separate.Length == 3) // line in the correct format
                    {
                        var fileUsername = separate[0].Replace("Username: ", "").Trim();
                        var filePassword = separate[1].Replace("Password: ", "").Trim();
                        var fileCC = separate[2].Replace("CC: ", "").Trim();

                        // match username, password & cc
                        if (fileUsername == User_Login && filePassword == Password_Login && fileCC == User_CC)
                        {
                            return true; // auth successfully
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ficheiro de autenticação do senhorio não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; // auth fail
        }

        public bool AuthenticateUser()
        {
            string personspath = @"C:\TP_POO_A25447\createpersons.txt";

            if (File.Exists(personspath))
            {
                var Line = File.ReadAllLines(personspath);

                foreach (var line in Line)
                {
                    // separate user, pw & cc with ","
                    var separate = line.Split(',');
                    if (separate.Length == 3) // line in the correct format
                    {

                        var fileUsername = separate[0].Replace("Username: ", "").Trim();
                        var filePassword = separate[1].Replace("Password: ", "").Trim();
                        var fileCC = separate[2].Replace("CC: ", "").Trim();

                        // match username, password & cc
                        if (fileUsername == User_Login && filePassword == Password_Login && fileCC == User_CC)
                        {
                            LoggedInUsername = fileUsername;
                            LoggedInCC = fileCC;
                            return true; // auth successfully
                        }
                    }
                }
            }

            return false; // auth fail
        }
        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(LoggedInUsername);
            return !string.IsNullOrEmpty(LoggedInCC);
        }

        // clear data of login
        public static void Logout()
        {
            LoggedInUsername = null;
            LoggedInCC = null;
        }
    }
}

