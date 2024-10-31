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
    public partial class ManagementProperties : Form
    {
        public ManagementProperties()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();

            // Fechar o Form atual
            this.Close();
        }

        private void btn_editproperty_Click(object sender, EventArgs e)
        {

        }
    }
}
