﻿using System;
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
    public partial class FormTenants : Form
    {
        public FormTenants()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            // Fechar o Form atual
            this.Close();
        }
    }
}
