using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class FileManagement
    {

        private string personspath = @"C:\TP_POO_A25447\createpersons.txt";


        public void SavePersons(string username, string password, string cc)
        {
            // save the username and password in the path with the right way
            string conteudo = $"Username: {username}, Password: {password}, CC: {cc}\n";

            File.AppendAllText(personspath, conteudo);
            MessageBox.Show("Conta registada!");

        }
    }
}










