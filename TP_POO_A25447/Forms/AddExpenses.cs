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
    /// <summary>
    /// Form for adding and managing property-related expenses
    /// Allows users to record different types of expenses with descriptions and amounts
    /// </summary>
    public partial class AddExpenses : Form
    {

        string expensesPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "TextFiles", "createpersons.txt");


        private string selectedProperty;

        /// <summary>
        /// Initializes a new instance of the AddExpenses form
        /// </summary>
        /// <param name="property">The selected property to associate expenses with</param>
        public AddExpenses(string property)
        {
            InitializeComponent();
            selectedProperty = property;
            txt_sellectedproperty.Text = property; // Display the selected property

            combobox_typeexpenses.Items.Clear();
            combobox_typeexpenses.Items.Add("Selecione uma opção");
            combobox_typeexpenses.Items.Add("Manutenção");
            combobox_typeexpenses.Items.Add("Reparação");
            combobox_typeexpenses.Items.Add("Melhorias");

            combobox_typeexpenses.SelectedIndex = 0;

        }

        /// <summary>
        /// Handles the back button click event
        /// Closes the current form
        /// </summary>
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        /// <summary>
        /// Handles the save expense button click event
        /// Validates input and saves the expense details to a file
        /// </summary>
        private void btn_saveexpense_Click(object sender, EventArgs e)
        {
            // Validate input
            if (combobox_typeexpenses.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txt_descriptionexpense.Text) || string.IsNullOrWhiteSpace(txt_amountexpense.Text))
            {
                MessageBox.Show("Preencha todos os campos para adicionar uma despesa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_amountexpense.Text, out decimal amount))
            {
                MessageBox.Show("Insira um valor para a despesa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Format the expense entry
            string expenseEntry = $"Imóvel: {selectedProperty}, Tipo: {combobox_typeexpenses.Text}, Descrição: {txt_descriptionexpense.Text.Trim()}, Valor: {amount:C}, Data: {DateTime.Now:dd/MM/yyyy}";

            try
            {
                // Save to the expenses file
                File.AppendAllText(expensesPath, expenseEntry + Environment.NewLine);
                MessageBox.Show("Despesa adicionada e associada ao imóvel", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear inputs for another entry
                combobox_typeexpenses.SelectedIndex = 0;
                txt_descriptionexpense.Clear();
                txt_amountexpense.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar a despesa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles key press events in the amount textbox
        /// Ensures only valid numeric input and one decimal point
        /// </summary>
        private void txt_amountexpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, control keys, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && txt_amountexpense.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
