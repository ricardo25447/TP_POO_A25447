using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_POO_A25447
{
    public partial class AssociateProperties : Form
    {
        private string propertiesPath = @"C:\TP_POO_A25447\properties.txt";
        public AssociateProperties()
        {
            InitializeComponent();

            this.Load += FormManageContracts_Load;
            listview_properties.View = View.Details; // show details
            listview_properties.Scrollable = true; // able scroll
            listview_properties.FullRowSelect = true; // select all line
            listview_properties.Columns.Add("Imóveis:", 865, HorizontalAlignment.Left); // fix scroll
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            FormAdmin formFormAdmin = new FormAdmin();
            formFormAdmin.Show();
            this.Hide(); //hide log in
        }

        private void btn_addcontract_Click(object sender, EventArgs e)
        {
            if (listview_properties.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um imóvel.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtain the property
            string selectedProperty = listview_properties.SelectedItems[0].Text;

            // open TenantContract
            TenantContract formAddContract = new TenantContract(selectedProperty);
            formAddContract.ShowDialog();
        }

        private void FormManageContracts_Load(object sender, EventArgs e)
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de imóveis não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // load properties
            var lines = File.ReadAllLines(propertiesPath);
            listview_properties.Items.Clear();

            foreach (var line in lines)
            {
                listview_properties.Items.Add(line.Trim());
            }

            if (listview_properties.Items.Count == 0)
            {
                MessageBox.Show("Não existem imóveis disponíveis para contratos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_activecontracts_Click(object sender, EventArgs e)
        {
            string contractsPath = @"C:\TP_POO_A25447\contracts.txt";

            if (!File.Exists(contractsPath))
            {
                MessageBox.Show("O ficheiro de contratos não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // verify if some property was sellected
            if (listview_properties.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um imóvel para visualizar os contratos ativos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtain the sellected property
            string selectedProperty = listview_properties.SelectedItems[0].Text;

            // read all line of txt
            var lines = File.ReadAllLines(contractsPath);
            var associatedContracts = new List<string>();

            foreach (var line in lines)
            {
                if (line.Contains($"Imóvel: {selectedProperty}"))
                {
                    // only username, cc and dates to show
                    var parts = line.Split(',');

                    // Atribuir partes esperadas
                    string tenant = parts.FirstOrDefault(p => p.Contains("Inquilino:"))?.Replace("Inquilino:", "").Trim();
                    string cc = parts.FirstOrDefault(p => p.Contains("CC:"))?.Replace("CC:", "").Trim();
                    string startDate = parts.FirstOrDefault(p => p.Contains("Início:"))?.Replace("Início:", "").Trim();
                    string endDate = parts.FirstOrDefault(p => p.Contains("Fim:"))?.Replace("Fim:", "").Trim();

                    associatedContracts.Add($"Inquilino: {tenant}, CC: {cc}, Início: {startDate}, Fim: {endDate}");
                }
            }

            // show contracts associated to tenant
            if (associatedContracts.Count > 0)
            {
                MessageBox.Show($"Contratos associados ao imóvel '{selectedProperty}':\n\n{string.Join("\n", associatedContracts)}",
                                "Contratos Ativos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Não existem contratos ativos para o imóvel '{selectedProperty}'.",
                                "Informação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
