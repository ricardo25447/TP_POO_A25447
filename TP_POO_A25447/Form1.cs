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
            string user_Login = txt_user.Text;
            string user_Password = txt_password.Text;

            Login login = new Login(user_Login, user_Password);


            if (login.AuthenticateAdmin() && admin_checkbox.Checked)
            {
                MessageBox.Show("Senhorio " + user_Login + " fez log in com sucesso!");

                //admin interface
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide(); //hide log in
            }
            else if (login.AuthenticateUser())
            {
                MessageBox.Show("Inquilino " + user_Login + " fez log in com sucesso!");

                //tanant interface
                FormTenants formTenants = new FormTenants();
                formTenants.Show();
                this.Hide(); //hide log in
            }
            else if (!admin_checkbox.Checked)
            {
                MessageBox.Show("Caso seja senhorio, por favor selecione a op��o 'Senhorio'!");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso n�o tenha conta, contacte o senhorio.", "Informa��o para novos utilizadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
