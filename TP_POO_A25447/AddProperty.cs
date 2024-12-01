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
    public partial class AddProperty : Form
    {
        public AddProperty()
        {
            InitializeComponent();

            ConfigureAutoCompleteUsername();
            ConfigureAutoCompleteCC();

            dropdown_typeproperty.Items.Clear();
            dropdown_typeproperty.Items.Add("Selecione uma opção");
            dropdown_typeproperty.Items.Add("Apartamento T1");
            dropdown_typeproperty.Items.Add("Apartamento T2");
            dropdown_typeproperty.Items.Add("Apartamento T3");
            dropdown_typeproperty.Items.Add("Vivenda Geminada T1");
            dropdown_typeproperty.Items.Add("Vivenda Geminada T2");
            dropdown_typeproperty.Items.Add("Vivenda Geminada T3");

            dropdown_typeproperty.SelectedIndex = 0;
        }

        private void dropdown_typeproperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_incomeproperty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addproperty_Click(object sender, EventArgs e)
        {
            // path file
            string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

            // txt values
            string propertyType = dropdown_typeproperty.Text.Trim();
            string propertyPrice = txt_priceproperty.Text.Trim();
            string propertyincome = txt_incomeproperty.Text.Trim();
            string propertyDistrict = txt_districtproperty.Text.Trim();
            string propertyMunicipality = txt_municipalityproperty.Text.Trim();
            string propertyParish = txt_parishproperty.Text.Trim();
            string propertyTenant = txt_inquilinoproperty.Text.Trim();
            string propertyTenantCC = txt_propertyusercc.Text.Trim();

            // verify if textbox's are empties
            if (string.IsNullOrWhiteSpace(propertyType) || string.IsNullOrWhiteSpace(propertyPrice) || string.IsNullOrWhiteSpace(propertyincome) || string.IsNullOrWhiteSpace(propertyDistrict) || string.IsNullOrWhiteSpace(propertyMunicipality) || string.IsNullOrWhiteSpace(propertyParish) || string.IsNullOrWhiteSpace(propertyTenant))
            {
                MessageBox.Show("Todos os campossão de preenchimento obrigatório para fazer o registo de uma propriedade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // file formart to save in txt
            string propertyInfo = $"Tipo de imóvel: {propertyType}, Preço do imóvel: {propertyPrice}, Renda Mensal da propriedade: {propertyincome}, Distrito: {propertyDistrict}, Concelho: {propertyMunicipality}, Freguesia: {propertyParish}, Inquilino: {propertyTenant}";

            try
            {
                // save in file txt
                File.AppendAllText(propertiesPath, propertyInfo + Environment.NewLine);

                MessageBox.Show("Foi adiciono/a um/a " + propertyType + ", localizado em " + propertyParish + ", " + propertyMunicipality + ", " + propertyDistrict + ", associada ao inquilino " + propertyTenant + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear textboxs
                dropdown_typeproperty.SelectedIndex = 0;
                txt_priceproperty.Clear();
                txt_incomeproperty.Clear();
                txt_districtproperty.Clear();
                txt_municipalityproperty.Clear();
                txt_parishproperty.Clear();
                txt_inquilinoproperty.Clear();
                txt_propertyusercc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao guardar as informações da propriedade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagementProperties formManagementProperties = new ManagementProperties();
            formManagementProperties.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                txt_inquilinoproperty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_inquilinoproperty.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_inquilinoproperty.AutoCompleteCustomSource = usernames;
            }
            else
            {
                MessageBox.Show("O ficheiro de contas não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureAutoCompleteCC()
        {
            string personspath = @"C:\TP_POO_A25447\createpersons.txt";

            // verify if file exist
            if (File.Exists(personspath))
            {
                // read all lines of txt
                var lines = File.ReadAllLines(personspath);
                var ncc = new AutoCompleteStringCollection();

                foreach (var line in lines)
                {
                    // obtain the user
                    var parts = line.Split(',');
                    if (parts.Length > 0)
                    {
                        string CC = parts[2].Replace("CC: ", "").Trim();
                        if (!string.IsNullOrWhiteSpace(CC))
                        {
                            ncc.Add(CC); // add name to autocomplete
                        }
                    }
                }

                // configure autocomplete to the textbox
                txt_propertyusercc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_propertyusercc.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_propertyusercc.AutoCompleteCustomSource = ncc;
            }
            else
            {
                MessageBox.Show("O ficheiro de contas não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}