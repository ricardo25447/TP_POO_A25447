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
    public partial class TenantContract : Form
    {
        private string selectedProperty;
        private static string contractsPath = @"C:\TP_POO_A25447\contracts.txt";

        public TenantContract(string property)
        {
            InitializeComponent();

            selectedProperty = property;

            // show the sellected property
            txt_selectedproperty.Text = property;
            txt_selectedproperty.ReadOnly = true; // readonly

            ConfigureAutoCompleteUsername();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide log in
        }

        private void btn_addcontract_Click(object sender, EventArgs e)
        {
            string contractsPath = @"C:\TP_POO_A25447\contracts.txt";

            // Obter dados do formulário
            string tenantName = txt_tenant.Text.Trim();
            string tenantCC = txt_tenantcc.Text.Trim();
            DateTime startDate = datetime_startcontract.Value;
            DateTime endDate = datetime_endcontract.Value;

            // check if the txt is not empty
            if (string.IsNullOrWhiteSpace(tenantName) || string.IsNullOrWhiteSpace(tenantCC))
            {
                MessageBox.Show("Preencha os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (endDate <= startDate)
            {
                MessageBox.Show("A data de fim deve ser posterior à data de início.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // verify if the property is already in contract
            if (IsPropertyAlreadyContracted(selectedProperty, contractsPath))
            {
                MessageBox.Show($"O imóvel '{selectedProperty}' já se encontra ocupado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // save in txt
                SaveContract(selectedProperty, tenantName, tenantCC, startDate, endDate);

                MessageBox.Show("Contrato adicionado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // close forms
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o contrato: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveContract(string property, string tenantName, string tenantCC, DateTime startDate, DateTime endDate)
        {
            string contractInfo = $"Imóvel: {property}, Inquilino: {tenantName}, CC: {tenantCC}, Data Início: {startDate.ToShortDateString()}, Data Fim: {endDate.ToShortDateString()}";

            File.AppendAllText(contractsPath, contractInfo + Environment.NewLine);
        }

        private void txt_tenant_TextChanged(object sender, EventArgs e)
        {
            string personsPath = @"C:\TP_POO_A25447\createpersons.txt";

            if (!File.Exists(personsPath))
            {
                MessageBox.Show("O ficheiro de inquilinos não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenantName = txt_tenant.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenantName))
            {
                txt_tenantcc.Clear();
                return;
            }

            var lines = File.ReadAllLines(personsPath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 3) // check if username and cc are not empties
                {
                    string fileTenantName = parts[0].Replace("Username: ", "").Trim();
                    string fileTenantCC = parts[2].Replace("CC: ", "").Trim();

                    if (fileTenantName.Equals(tenantName, StringComparison.OrdinalIgnoreCase))
                    {
                        txt_tenantcc.Text = fileTenantCC; // autocomplete cc
                        return;
                    }
                }
            }

            // clear cc if the user not found
            txt_tenantcc.Clear();
        }

        private void ConfigureAutoCompleteUsername()
        {
            string personspath = @"C:\TP_POO_A25447\createpersons.txt";

            // verify if file exist
            if (File.Exists(personspath))
            {
                // read all lines of txt
                var lines = File.ReadAllLines(personspath);
                var usernames = new AutoCompleteStringCollection();

                foreach (var line in lines)
                {
                    // obtain the user
                    var parts = line.Split(',');
                    if (parts.Length > 0)
                    {
                        string username = parts[0].Replace("Username: ", "").Trim();
                        if (!string.IsNullOrWhiteSpace(username))
                        {
                            usernames.Add(username); // add name to autocomplete
                        }
                    }
                }

                // configure autocomplete to the textbox
                txt_tenant.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_tenant.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_tenant.AutoCompleteCustomSource = usernames;
            }
            else
            {
                MessageBox.Show("O ficheiro de contas não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsPropertyAlreadyContracted(string property, string contractsPath)
        {
            if (!File.Exists(contractsPath))
            {
                return false; // if property not found the contract cant be successfuly
            }

            var lines = File.ReadAllLines(contractsPath);

            foreach (var line in lines)
            {
                if (line.Contains($"Imóvel: {property}")) // verify if property is occupied
                {
                    return true;
                }
            }

            return false;
        }

    }
}






