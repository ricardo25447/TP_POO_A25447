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
            listView1.View = View.Details; // show details
            listView1.Scrollable = true; // able scroll
            listView1.FullRowSelect = true; // select all line
            listView1.Columns.Add("Imóveis:", 900, HorizontalAlignment.Left); // fix scroll


            LoadProperties();
        }

        private void LoadProperties()
        {
            if (!File.Exists(propertiesPath))
            {
                MessageBox.Show("O ficheiro de propriedades não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lê todas as linhas do ficheiro
            var lines = File.ReadAllLines(propertiesPath);
            listView1.Items.Clear(); // Limpa os itens existentes no ListView

            foreach (var line in lines)
            {
                // Adiciona cada linha como um item no ListView
                listView1.Items.Add(new ListViewItem(line.Trim()));
            }

            if (listView1.Items.Count == 0)
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

            // Verifica se algum item foi selecionado
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma propriedade para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o item selecionado
            string selectedLine = listView1.SelectedItems[0].Text;

            // Lê todas as linhas do ficheiro
            var lines = File.ReadAllLines(propertiesPath).ToList();

            // Remove a linha correspondente
            if (lines.Remove(selectedLine))
            {
                // Atualiza o ficheiro
                File.WriteAllLines(propertiesPath, lines);

                MessageBox.Show("Propriedade removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarrega a lista no ListView
                LoadProperties();
            }
            else
            {
                MessageBox.Show("Erro ao remover a propriedade. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagementProperties formManagementProperties = new ManagementProperties();
            formManagementProperties.Show();

            // Fecha o formulário atual
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

