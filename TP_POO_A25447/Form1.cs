using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TP_POO_A25447
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;

            if (user == "admin" && password == "admin123")
            {
                MessageBox.Show("Login como Admin efetuado com sucesso!");

                //admin interface
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide(); //hide log in
            }
            else if (user == "inquilino" && password == "inquilino123")
            {
                MessageBox.Show("Login como Inquilino efetuado com sucesso!");

                //tanant interface
                FormTenants formTenants = new FormTenants();
                formTenants.Show();
                this.Hide(); //hide log in
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou palavra-passe incorretos.", "Erro de autentica��o", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_user.Clear();
                txt_password.Clear();

                txt_user.Focus();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
