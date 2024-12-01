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
    public partial class ManagementProperties : Form
    {
        public ManagementProperties()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();

            // close form
            this.Close();
        }

        private void btn_editproperty_Click(object sender, EventArgs e)
        {

        }

        private void btn_addproperty_Click(object sender, EventArgs e)
        {
            AddProperty formAddProperty = new AddProperty();
            formAddProperty.Show();
            this.Hide();
        }

        private void btn_listproperties_Click(object sender, EventArgs e)
        {
            string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

            // verify if file exist
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de imóveis não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // read all lines of txt
            var lines = File.ReadAllLines(propertiesPath);

            if (lines.Length == 0)
            {
                MessageBox.Show("Não existem imóveis registados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // create a string to show all properties
            string propertiesList = string.Join(Environment.NewLine, lines);

            // show properties in a list
            MessageBox.Show($"Lista de Imóveis:\n\n{propertiesList}", "Lista de Imóveis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_deleteproperty_Click(object sender, EventArgs e)
        {
            RemoveProperties formRemoveProperties = new RemoveProperties();
            formRemoveProperties.Show();
            this.Hide();
        }
    }
}

