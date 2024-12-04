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
    public partial class FormTenants : Form
    {
        public FormTenants()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_showcontracts_T_Click(object sender, EventArgs e)
        {
            string contractsPath = @"C:\TP_POO_A25447\contracts.txt";

            if (!File.Exists(contractsPath))
            {
                MessageBox.Show("O ficheiro de contratos não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // verify if tenant is authenticated
            if (string.IsNullOrWhiteSpace(Login.LoggedInUsername) || string.IsNullOrWhiteSpace(Login.LoggedInCC))
            {
                MessageBox.Show("Utilizador não autenticado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // read all lines of txt
            var lines = File.ReadAllLines(contractsPath);
            var tenantContracts = new List<string>();

            // show only the contracts of user loggedin
            foreach (var line in lines)
            {
                if (line.Contains($"Inquilino: {Login.LoggedInUsername}") && line.Contains($"CC: {Login.LoggedInCC}"))
                {
                    tenantContracts.Add(line);
                }
            }

            // show the contracts matched
            if (tenantContracts.Count > 0)
            {
                MessageBox.Show($"Contratos associados a {Login.LoggedInUsername}:\n\n{string.Join("\n", tenantContracts)}", "Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Não existem contratos associados ao inquilino {Login.LoggedInUsername}.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_showincomes_T_Click(object sender, EventArgs e)
        {

        }
    }
}
