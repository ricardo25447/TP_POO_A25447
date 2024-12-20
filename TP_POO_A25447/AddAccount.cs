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
    /// Form for adding new user accounts to the system
    /// Handles user registration with username, password, and CC number
    /// </summary>
    public partial class AddAccount : Form
    {
        /// <summary>
        /// Initializes a new instance of the AddAccount form
        /// Sets initial focus to the username textbox
        /// </summary>
        public AddAccount()
        {
            InitializeComponent();
            adduser_txt.Focus();
        }


        /// <summary>
        /// Handles the click event of the Add Account button
        /// Validates input fields and creates a new user account
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void btn_addaccount_Click(object sender, EventArgs e)
        {
            string username = adduser_txt.Text;
            string password = addpassword_txt.Text;
            string cc = txt_ccnumber.Text;


            // validate if the textbox's are empties
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(cc))
            {
                MessageBox.Show("Preencha os campos!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                adduser_txt.Clear();
                addpassword_txt.Clear();
                txt_ccnumber.Clear();  
                return;
            }
            else
            {
                FileManagement fileManagement = new FileManagement();
                fileManagement.SavePersons(username, password, cc);
            }


            adduser_txt.Clear();
            addpassword_txt.Clear();
            txt_ccnumber.Clear();

            adduser_txt.Focus();

        }

        /// <summary>
        /// Handles the click event of the Back button
        /// Prompts for confirmation before returning to the Manage Persons form
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
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
        /// <summary>
        /// Handles the text changed event of the password textbox
        /// Masks the password input with asterisks for security
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void addpassword_txt_TextChanged(object sender, EventArgs e)
        {
            addpassword_txt.PasswordChar = '*';
        }
        /// <summary>
        /// Handles the text changed event of the username textbox
        /// Currently not implemented with specific functionality
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void adduser_txt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
