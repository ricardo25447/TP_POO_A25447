﻿using System;
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

            // verify if the file exist
            if (!File.Exists(personspath))
            {
                MessageBox.Show("O ficheiro de contas não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // gets the values entered by the admin
            string usernameToRemove = txt_removeuser.Text.Trim(); // username
            string ccToRemove = txt_ccremoveuser.Text.Trim();     // cc number

            // verify if the txt are empties
            if (string.IsNullOrWhiteSpace(usernameToRemove) || string.IsNullOrWhiteSpace(ccToRemove))
            {
                MessageBox.Show("Por favor, preencha ambos os campos: Nome de Utilizador e Número de Cartão de Cidadão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
            $"Está prestes a remover a conta do inquilino \"{usernameToRemove}\" com o número de CC \"{ccToRemove}\". Pretende mesmo continuar?",
            "Confirmação de Remoção",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return; // if the user press no the operation will be aborted
            }

            // read all lines of txt
            var lines = File.ReadAllLines(personspath).ToList();
            var updatedLines = new List<string>();
            bool userRemoved = false;

            foreach (var line in lines)
            {
                // separate username, pw & cc
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string fileUsername = parts[0].Replace("Username: ", "").Trim();
                    string fileCC = parts[2].Replace("CC: ", "").Trim();

                    // verify if the username and cc already exist
                    if (fileUsername == usernameToRemove && fileCC == ccToRemove)
                    {
                        userRemoved = true; // match the account and remove it
                    }
                    else
                    {
                        updatedLines.Add(line);
                    }
                }
                else
                {
                    updatedLines.Add(line);
                }
            }

            if (userRemoved)
            {
                // rewrite the file with the remaining accounts
                File.WriteAllLines(personspath, updatedLines);
                MessageBox.Show("Conta removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // cleat txt
                txt_removeuser.Clear();
                txt_ccremoveuser.Clear();
            }
            else
            {
                MessageBox.Show("A conta especificada não foi encontrada. Verifique os dados inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_backaccountuser_Click(object sender, EventArgs e)
        {
            ManagePersonsForm formManagePersons = new ManagePersonsForm();
            formManagePersons.Show();
            this.Hide(); //hide log in
        }

    }
}
