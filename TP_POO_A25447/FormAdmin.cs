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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btn_showcontracts_Click(object sender, EventArgs e)
        {
            AssociateProperties formAssociateProperties = new AssociateProperties();
            formAssociateProperties.Show();
            this.Hide(); //hide log in
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            // Fechar o Form atual
            this.Close();
        }

        private void btn_showproperty_Click(object sender, EventArgs e)
        {
            ManagementProperties formManagementProperties = new ManagementProperties();
            formManagementProperties.Show();
            this.Hide(); //hide log in
        }

        private void managepersons_Click(object sender, EventArgs e)
        {
            ManagePersonsForm ManagementPersons = new ManagePersonsForm();
            ManagementPersons.Show();
            this.Hide(); //hide log in
        }

        private void btn_showincomes_Click(object sender, EventArgs e)
        {

        }

        private void btn_showexpenses_Click(object sender, EventArgs e)
        {
            ExpensesPropertycs formExpensesPropertycs = new ExpensesPropertycs();
            formExpensesPropertycs.Show();
            this.Hide(); //hide log in
        }
    }
}
