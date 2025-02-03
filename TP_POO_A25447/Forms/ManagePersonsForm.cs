using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_POO_A25447
{
    public partial class ManagePersonsForm : Form
    {

        public ManagePersonsForm()
        {
            InitializeComponent();

        }

        private void btn_createaccount_Click(object sender, EventArgs e)
        {
            AddAccount formaddaccount = new AddAccount();
            formaddaccount.Show();
            this.Hide(); //hide log in
        }

        private void btn_removeaccount_Click(object sender, EventArgs e)
        {
            RemoveAccountUser formRemoveAccount = new RemoveAccountUser();
            formRemoveAccount.Show();
            this.Hide(); //hide log in
        }

        private void btn_listaccount_Click(object sender, EventArgs e)
        {
            string personspath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "TextFiles", "createpersons.txt");

            if (File.Exists(personspath))
            {
                // read all lines
                var Line = File.ReadAllLines(personspath);

                // check line
                if (Line.Length > 0)
                {
                    var usernames = new List<string>();

                    foreach (var line in Line)
                    {
                        var separate = line.Split(',');
                        if (separate.Length > 0)
                        {
                            var username = separate[0].Replace("Username: ", "").Trim();

                            if (!string.IsNullOrWhiteSpace(username))
                            {
                                usernames.Add(username);
                            }
                        }
                    }

                    // show users
                    if (usernames.Count > 0)
                    {
                        MessageBox.Show($"Contas criadas:\n{string.Join("\n", usernames)}");
                    }
                    else
                    {
                        MessageBox.Show("Não existem contas criadas.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // file empty
                    MessageBox.Show("O ficheiro está vazio. Não existem contas criadas.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // file doesn't exist
                MessageBox.Show("Não existe base de dados para consultar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide(); //hide log in
        }
    }
}
