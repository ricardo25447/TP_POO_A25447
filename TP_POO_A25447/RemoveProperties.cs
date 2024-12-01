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
            LoadProperties();
        }

        private void LoadProperties()
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de propriedades não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // read all lines of txt
            var lines = File.ReadAllLines(propertiesPath);
            checkedListBoxProperties.Items.Clear();

            foreach (var line in lines)
            {
                checkedListBoxProperties.Items.Add(line.Trim()); // add a line of txt to the list
            }

            if (checkedListBoxProperties.Items.Count == 0)
            {
                MessageBox.Show("Não existem propriedades registadas.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_removeproperty_Click(object sender, EventArgs e)
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de propriedades não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // verify if line was sellectex
            if (checkedListBoxProperties.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma propriedade para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtain the sellected line
            string selectedLine = checkedListBoxProperties.SelectedItem.ToString();

            // read all lines of txt
            var lines = File.ReadAllLines(propertiesPath).ToList();

            // remove the selected line
            if (lines.Remove(selectedLine))
            {
                // refresh txt
                File.WriteAllLines(propertiesPath, lines);

                MessageBox.Show("Propriedade removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reload the list
                LoadProperties();
            }
            else
            {
                MessageBox.Show("Erro ao remover a propriedade. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBoxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagementProperties formManagementProperties = new ManagementProperties();
            formManagementProperties.Show();

            // close form
            this.Close();
        }
    }

}

