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
    public partial class IncomeManagement : Form
    {
        private string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

        public IncomeManagement()
        {
            InitializeComponent();
            this.Load += FormManageContracts_Load;
            listview_properties.View = View.Details; // show details
            listview_properties.Scrollable = true; // able scroll
            listview_properties.FullRowSelect = true; // select all line
            listview_properties.Columns.Add("Imóveis:", 865, HorizontalAlignment.Left); // fix scroll

        }

        private void btn_showincomes_Click(object sender, EventArgs e)
        {
           
        }
    

        private void FormManageContracts_Load(object sender, EventArgs e)
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de propriedades não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // load properties on listview
            var lines = File.ReadAllLines(propertiesPath);
            listview_properties.Items.Clear();

            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    listview_properties.Items.Add(line.Trim());
                }
            }

            if (listview_properties.Items.Count == 0)
            {
                MessageBox.Show("Não existem imóveis disponíveis para contratos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            // close form
            this.Close();
        }
    }
}
