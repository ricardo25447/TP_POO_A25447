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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        private void adduser_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addpassword_txt_TextChanged(object sender, EventArgs e)
        {
            addpassword_txt.PasswordChar = '*';
        }

        private void btn_addaccount_Click(object sender, EventArgs e)
        {
            string username = adduser_txt.Text;
            string password = addpassword_txt.Text;


            // validate if the textbox's are empties
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Preencha os campos!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                adduser_txt.Clear();
                addpassword_txt.Clear();
                return;
            }
            else
            {
                FileManagement fileManagement = new FileManagement();
                fileManagement.SavePersons(username, password);
            }


            adduser_txt.Clear();
            addpassword_txt.Clear();

        }

        private void btn_back_addaccount_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Tem a certeza que deseja retroceder?", "Confirmar Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ManagePersonsForm managePersonsForm = new ManagePersonsForm();
                managePersonsForm.Show();
                this.Hide(); //hide log in
            }
            else
            {
                MessageBox.Show("Continue a criação da conta.");
            }
        }

    }
}


