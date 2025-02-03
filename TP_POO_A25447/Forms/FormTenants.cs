using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_POO_A25447.Classes;

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

        private void btn_showexpenses_Click(object sender, EventArgs e)
        {
            string contractsPath = @"C:\TP_POO_A25447\contracts.txt"; // Path to contracts file
            string expensesPath = @"C:\TP_POO_A25447\expenses.txt";   // Path to expenses file

            if (!File.Exists(contractsPath))
            {
                MessageBox.Show("O ficheiro de contratos não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(expensesPath))
            {
                MessageBox.Show("O ficheiro de despesas não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assuming the logged-in user details are available
            string loggedInTenant = Login.LoggedInUsername; // Replace with actual logged-in username
            string loggedInCC = Login.LoggedInCC;           // Replace with actual logged-in CC

            // Find the property associated with the logged-in tenant
            var contractLines = File.ReadAllLines(contractsPath);
            string associatedProperty = contractLines.FirstOrDefault(line => line.Contains($"Inquilino: {loggedInTenant}") && line.Contains($"CC: {loggedInCC}"));

            if (string.IsNullOrWhiteSpace(associatedProperty))
            {
                MessageBox.Show("Nenhum imóvel associado ao inquilino atual.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Extract the property name from the contract line
            string propertyName = associatedProperty.Split(',')[0].Replace("Imóvel:", "").Trim();

            // Find all expenses associated with the property
            var expenseLines = File.ReadAllLines(expensesPath);
            var associatedExpenses = expenseLines
                .Where(line => line.Contains($"Imóvel: {propertyName}"))
                .Select(line =>
                {
                    // Extract only the relevant fields from the expense line
                    var parts = line.Split(',');
                    string type = parts.FirstOrDefault(p => p.Contains("Tipo:"))?.Replace("Tipo:", "").Trim();
                    string description = parts.FirstOrDefault(p => p.Contains("Descrição:"))?.Replace("Descrição:", "").Trim();
                    string value = parts.FirstOrDefault(p => p.Contains("Valor:"))?.Replace("Valor:", "").Trim();
                    string date = parts.FirstOrDefault(p => p.Contains("Data:"))?.Replace("Data:", "").Trim();

                    // Format the output for each expense
                    return $"Tipo: {type}, Descrição: {description}, Valor: {value}, Data: {date}";
                })
                .ToList();

            // Display the expenses
            if (associatedExpenses.Count > 0)
            {
                MessageBox.Show($"Despesas associadas ao imóvel '{propertyName}':\n\n{string.Join("\n", associatedExpenses)}",
                                "Despesas do Imóvel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Não existem despesas associadas ao imóvel '{propertyName}'.",
                                "Informação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

    }
}
