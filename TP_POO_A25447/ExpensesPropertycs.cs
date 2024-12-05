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
    public partial class ExpensesPropertycs : Form
    {
        private string propertiesPath = @"C:\TP_POO_A25447\properties.txt";

        public ExpensesPropertycs()
        {
            InitializeComponent();
            LoadProperties(); // Load properties when the form is initialized
            this.Load += EditProperties_Load;
        }

        private void EditProperties_Load(object sender, EventArgs e)
        {
            listview_properties.View = View.Details; // show details
            listview_properties.Scrollable = true; // able scroll
            listview_properties.FullRowSelect = true; // select all line
            listview_properties.Columns.Add("Imóveis:", 865, HorizontalAlignment.Left); // fix scroll
        }

        // Load properties into the ListView
        private void LoadProperties()
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de imóveis não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Read all properties and populate the ListView
            var lines = File.ReadAllLines(propertiesPath);
            listview_properties.Items.Clear();

            foreach (var line in lines)
            {
                listview_properties.Items.Add(new ListViewItem(line.Trim()));
            }

            if (listview_properties.Items.Count == 0)
            {
                MessageBox.Show("Não existem imóveis registados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_addexpenses_Click(object sender, EventArgs e)
        {
            // Ensure a property is selected
            if (listview_properties.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um imóvel para adicionar uma despesa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected property
            string selectedProperty = listview_properties.SelectedItems[0].Text;

            // Open the Add Expense Form with the selected property
            using (AddExpenses addExpenseForm = new AddExpenses(selectedProperty))
            {
                addExpenseForm.ShowDialog(); // Open the form as a dialog
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormAdmin FormAdmin = new FormAdmin();
            FormAdmin.Show();
            this.Hide(); //hide log in
        }
    }
}
