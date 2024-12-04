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
    public partial class RemoveProperties : Form
    {
        private string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

        public RemoveProperties()
        {
            InitializeComponent();
        }

        private void RemoveProperties_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details; // show details
            listView1.Scrollable = true; // able scroll
            listView1.FullRowSelect = true; // select all line
            listView1.Columns.Add("Imóveis:", 865, HorizontalAlignment.Left); // fix scroll


            LoadProperties();
        }

        private void LoadProperties()
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de propriedades não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // read all lines 
            var lines = File.ReadAllLines(propertiesPath);
            listView1.Items.Clear(); // clear objects in list view

            foreach (var line in lines)
            {
                // add a object to the list view
                listView1.Items.Add(new ListViewItem(line.Trim()));
            }

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Não existem imóveis registados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_removeproperty_Click(object sender, EventArgs e)
        {
            {
                if (!File.Exists(propertiesPath))
                {
                    MessageBox.Show("O ficheiro de imóveis não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verify if a property is selected
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecione um imóvel para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected property
                string selectedLine = listView1.SelectedItems[0].Text;

                // Check if the property has active contracts
                if (PropertyContract(selectedLine))
                {
                    var result = MessageBox.Show($"O imóvel '{selectedLine}' está associado a um contrato ativo. Deseja mesmo removê-lo? Todas as associações ao contrato serão removidas.",
                                                 "Aviso",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        return; // Do not remove if the user selects "No"
                    }

                    // Remove associated contracts
                    RemovePropertyContracts(selectedLine);
                }

                // Read all lines from the properties file
                var lines = File.ReadAllLines(propertiesPath).ToList();

                // Remove the selected property
                if (lines.Remove(selectedLine))
                {
                    // Update the properties file
                    File.WriteAllLines(propertiesPath, lines);

                    MessageBox.Show("Imóvel e contratos associados foram removidos!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the properties list
                    LoadProperties();
                }
                else
                {
                    MessageBox.Show("Erro ao remover o imóvel. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagementProperties formManagementProperties = new ManagementProperties();
            formManagementProperties.Show();

            // close forms
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool PropertyContract(string property)
        {
            string contractsPath = @"C:\TP_POO_A25447\contracts.txt";

            if (!File.Exists(contractsPath))
            {
                return false; // if the property doesnt exist dont put any contract
            }

            var lines = File.ReadAllLines(contractsPath);

            foreach (var line in lines)
            {
                if (line.Contains($"Imóvel: {property}"))
                {
                    return true; // if the property already in contract
                }
            }

            return false; // property is not associate to any contract
        }

        private void RemovePropertyContracts(string property)
        {
            string contractsPath = @"C:\TP_POO_A25447\contracts.txt";

            if (!File.Exists(contractsPath))
                return;

            // Read all lines from the contracts file
            var lines = File.ReadAllLines(contractsPath).ToList();

            // Filter out contracts associated with the selected property
            var updatedLines = lines.Where(line => !line.Contains($"Imóvel: {property}")).ToList();

            // Update the contracts file
            File.WriteAllLines(contractsPath, updatedLines);

            MessageBox.Show($"Todos os contratos associados ao imóvel '{property}' foram removidos.",
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }


}

