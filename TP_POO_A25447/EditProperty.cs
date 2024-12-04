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
    public partial class EditProperty : Form
    {
        private string propertiesPath = @"C:\TP_POO_A25447\properties.txt";
        public EditProperty()
        {
            InitializeComponent();
            this.Load += EditProperties_Load;
            LoadProperties();
        }

        private void EditProperties_Load(object sender, EventArgs e)
        {
            listview_editproperties.View = View.Details; // show details
            listview_editproperties.Scrollable = true; // able scroll
            listview_editproperties.FullRowSelect = true; // select all line
            listview_editproperties.Columns.Add("Imóveis:", 865, HorizontalAlignment.Left); // fix scroll
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
            listview_editproperties.Items.Clear(); // clear objects in list view

            foreach (var line in lines)
            {
                // add a object to the list view
                listview_editproperties.Items.Add(new ListViewItem(line.Trim()));
            }

            if (listview_editproperties.Items.Count == 0)
            {
                MessageBox.Show("Não existem imóveis registados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagementProperties formManagementProperties = new ManagementProperties();
            formManagementProperties.Show();
            // close form
            this.Close();
        }

        private void btn_editproperty_Click(object sender, EventArgs e)
        {
            if (listview_editproperties.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um imóvel para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Oobtain the sellected property
            string selectedProperty = listview_editproperties.SelectedItems[0].Text;

            // open edit form
            ModifyPropertyData editPropertyForm = new ModifyPropertyData(selectedProperty);
            editPropertyForm.ShowDialog();

            // reload the list after save
            LoadProperties();
        }
    }
}
