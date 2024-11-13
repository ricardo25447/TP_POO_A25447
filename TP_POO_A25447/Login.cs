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
            string landlordPath = @"C:\TP_POO_A25447\landlord.txt"; // file path

            if (File.Exists(landlordPath))
            {
                var Line = File.ReadAllLines(landlordPath); // Lê todas as linhas do ficheiro

                foreach (var line in Line)
                {
                    // separate user and pw with ","
                    var separate = line.Split(',');
                    if (separate.Length == 2) // line in the correct format
                    {
                        var fileUsername = separate[0].Replace("Username: ", "").Trim();
                        var filePassword = separate[1].Replace("Password: ", "").Trim();

                        // match username & password
                        if (fileUsername == User_Login && filePassword == Password_Login)
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
                    // separate user and pw with ","
                    var separate = line.Split(',');
                    if (separate.Length == 2) // line in the correct format
                    {

                        var fileUsername = separate[0].Replace("Username: ", "").Trim();
                        var filePassword = separate[1].Replace("Password: ", "").Trim();

                        // match username & password
                        if (fileUsername == User_Login && filePassword == Password_Login)
                        {
                            return true; // auth successfully
                        }
                    }
                }
            }

            return false; // auth fail
        }

    }
}

