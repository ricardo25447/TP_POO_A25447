using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_POO_A25447
{
    public partial class ModifyPropertyData : Form
    {
        private string originalProperty;
        private string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

        public ModifyPropertyData(string property)
        {
            InitializeComponent();

            originalProperty = property;

            // put the data on txt and combo
            PopulateFields(property);
        }

        private void PopulateFields(string property)
        {
            var parts = property.Split(',');

            if (parts.Length >= 6)
            {
                combobox_typeproperty.Text = parts[0].Replace("Tipo de imóvel: ", "").Trim();
                txt_priceproperty.Text = parts[1].Replace("Preço: ", "").Trim();
                txt_incomeproperty.Text = parts[2].Replace("Renda Mensal: ", "").Trim();
                txt_districtproperty.Text = parts[3].Replace("Distrito: ", "").Trim();
                txt_municipalityproperty.Text = parts[4].Replace("Concelho: ", "").Trim();
                txt_parishproperty.Text = parts[5].Replace("Freguesia: ", "").Trim();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EditProperty formEditProperty = new EditProperty();
            formEditProperty.Show();
            // close form
            this.Close();
        }

        private void btn_savenewdata_Click(object sender, EventArgs e)
        {
            // obtain a updated data
            string updatedProperty = $"Tipo de imóvel: {combobox_typeproperty.Text.Trim()}, Preço do imóvel: {txt_priceproperty.Text.Trim()}, Renda Mensal do Imóvel: {txt_incomeproperty.Text.Trim()}, Distrito: {txt_districtproperty.Text.Trim()}, Concelho: {txt_municipalityproperty.Text.Trim()}, Freguesia: {txt_parishproperty.Text.Trim()}";
            
            try
            {
                // read all lines of txt
                var lines = File.ReadAllLines(propertiesPath).ToList();

                // sub the edit update
                int index = lines.IndexOf(originalProperty);
                if (index != -1)
                {
                    lines[index] = updatedProperty;
                    File.WriteAllLines(propertiesPath, lines);

                    MessageBox.Show("Imóvel atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); // close after save
                }
                else
                {
                    MessageBox.Show("Erro ao encontrar o imóvel original. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o imóvel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
