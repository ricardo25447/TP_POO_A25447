﻿using System;
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
        public AddProperty(string property = null)
        {
            InitializeComponent();

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
        private void btn_addproperty_Click(object sender, EventArgs e)
        {
            // path file
            string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

            // txt values
            string propertyType = dropdown_typeproperty.Text.Trim();
            string propertyPrice = txt_priceproperty.Text.Trim();
            string propertyIncome = txt_incomeproperty.Text.Trim();
            string propertyDistrict = txt_districtproperty.Text.Trim();
            string propertyMunicipality = txt_municipalityproperty.Text.Trim();
            string propertyParish = txt_parishproperty.Text.Trim();



            // verify if textbox's are empties
            if (string.IsNullOrWhiteSpace(propertyType) || string.IsNullOrWhiteSpace(propertyPrice) || string.IsNullOrWhiteSpace(propertyIncome) || string.IsNullOrWhiteSpace(propertyDistrict) || string.IsNullOrWhiteSpace(propertyMunicipality) || string.IsNullOrWhiteSpace(propertyParish))
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório para fazer o registo de um imóvel.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // file formart to save in txt
            string propertyInfo = $"Tipo de imóvel: {propertyType}, Preço do imóvel: {propertyPrice}, Renda Mensal do Imóvel: {propertyIncome}, Distrito: {propertyDistrict}, Concelho: {propertyMunicipality}, Freguesia: {propertyParish}";

            try
            {
                // save in file txt
                File.AppendAllText(propertiesPath, propertyInfo + Environment.NewLine);

                MessageBox.Show("Foi adiciono/a um/a " + propertyType + ", localizado em " + propertyParish + ", " + propertyMunicipality + ", " + propertyDistrict + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear textboxs
                dropdown_typeproperty.SelectedIndex = 0;
                txt_priceproperty.Clear();
                txt_incomeproperty.Clear();
                txt_districtproperty.Clear();
                txt_municipalityproperty.Clear();
                txt_parishproperty.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao guardar as informações do imóvel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_priceproperty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers, backspace and decimal dot
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // only numbers
            }
        }

        private void txt_incomeproperty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers, backspace and decimal dot
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // only numbers
            }
        }
    }
}