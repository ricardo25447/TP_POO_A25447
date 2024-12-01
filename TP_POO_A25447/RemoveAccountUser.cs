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
    public partial class RemoveAccountUser : Form
    {
        public RemoveAccountUser()
        {
            InitializeComponent();
        }

        private void RemoveAccountUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_removeuser_Click(object sender, EventArgs e)
        {

            string personspath = @"C:\TP_POO_A25447\createpersons.txt";

            if (!File.Exists(personspath))
            {
                MessageBox.Show("O ficheiro de contas não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obter os dados das TextBoxes
            string usernameToRemove = txt_removeuser.Text.Trim();
            string ccToRemove = txt_ccremoveuser.Text.Trim();

            // Verifica se ambas as TextBoxes estão preenchidas
            if (string.IsNullOrWhiteSpace(usernameToRemove) || string.IsNullOrWhiteSpace(ccToRemove))
            {
                MessageBox.Show("Por favor, preencha ambos os campos: Nome de Utilizador e Número de Cartão de Cidadão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lê todas as linhas do ficheiro
            var lines = File.ReadAllLines(personspath).ToList();
            var updatedLines = new List<string>();
            bool userRemoved = false;

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length > 2) // Garante que existem pelo menos três partes (Username, algo, CC)
                {
                    string username = parts[0].Replace("Username: ", "").Trim();
                    string cc = parts[2].Replace("CC: ", "").Trim();

                    // Adiciona logs de depuração (opcional)
                    Console.WriteLine($"Lido do ficheiro: Username = {username}, CC = {cc}");

                    // Verifica se a linha deve ser removida
                    if (username == usernameToRemove && cc == ccToRemove)
                    {
                        userRemoved = true; // Marca que um utilizador foi removido
                    }
                    else
                    {
                        updatedLines.Add(line); // Mantém a linha na lista atualizada
                    }
                }
                else
                {
                    // Se a linha não estiver no formato esperado, ignora
                    updatedLines.Add(line);
                }
            }

            if (userRemoved)
            {
                // Reescreve o ficheiro com as contas restantes
                File.WriteAllLines(personspath, updatedLines);
                MessageBox.Show("Conta removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                txt_removeuser.Clear();
                txt_ccremoveuser.Clear();
            }
            else
            {
                MessageBox.Show("A conta especificada não foi encontrada. Certifique-se de que o Nome de Utilizador e o Número de Cartão de Cidadão estão corretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }



        private void btn_backaccountuser_Click(object sender, EventArgs e)
        {
            ManagePersonsForm formManagePersons = new ManagePersonsForm();
            formManagePersons.Show();
            this.Hide(); //hide log in
        }

        private void LoadAutoCompleteData()
        {
            string personspath = @"C:\TP_POO_A25447\createpersons.txt";

            if (File.Exists(personspath))
            {
                var lines = File.ReadAllLines(personspath);
                var usernames = new AutoCompleteStringCollection();
                var ccNumbers = new AutoCompleteStringCollection();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length > 0)
                    {
                       
                        var username = parts[0].Replace("Username: ", "").Trim();
                        var cc = parts.Length > 1 ? parts[1].Replace("CC: ", "").Trim() : "";

                        if (!string.IsNullOrWhiteSpace(username))
                            usernames.Add(username);

                        if (!string.IsNullOrWhiteSpace(cc))
                            ccNumbers.Add(cc);
                    }
                }

                // Configura o AutoComplete para os TextBoxes
                txt_removeuser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_removeuser.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_removeuser.AutoCompleteCustomSource = usernames;

                txt_ccremoveuser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_ccremoveuser.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_ccremoveuser.AutoCompleteCustomSource = ccNumbers;
            }
            else
            {
                MessageBox.Show("O ficheiro de contas não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
