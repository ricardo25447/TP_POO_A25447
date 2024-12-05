namespace TP_POO_A25447
{
    partial class FormTenants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_showcontracts_T = new Button();
            btn_showincomes_T = new Button();
            btn_showdocuments_T = new Button();
            btn_logout = new Button();
            btn_showexpenses = new Button();
            SuspendLayout();
            // 
            // btn_showcontracts_T
            // 
            btn_showcontracts_T.Location = new Point(8, 7);
            btn_showcontracts_T.Margin = new Padding(2);
            btn_showcontracts_T.Name = "btn_showcontracts_T";
            btn_showcontracts_T.Size = new Size(143, 25);
            btn_showcontracts_T.TabIndex = 0;
            btn_showcontracts_T.Text = "Consultar Contratos";
            btn_showcontracts_T.UseVisualStyleBackColor = true;
            btn_showcontracts_T.Click += btn_showcontracts_T_Click;
            // 
            // btn_showincomes_T
            // 
            btn_showincomes_T.Location = new Point(8, 63);
            btn_showincomes_T.Margin = new Padding(2);
            btn_showincomes_T.Name = "btn_showincomes_T";
            btn_showincomes_T.Size = new Size(143, 25);
            btn_showincomes_T.TabIndex = 1;
            btn_showincomes_T.Text = "Consultar Rendas";
            btn_showincomes_T.UseVisualStyleBackColor = true;
            btn_showincomes_T.Click += btn_showincomes_T_Click;
            // 
            // btn_showdocuments_T
            // 
            btn_showdocuments_T.Location = new Point(8, 92);
            btn_showdocuments_T.Margin = new Padding(2);
            btn_showdocuments_T.Name = "btn_showdocuments_T";
            btn_showdocuments_T.Size = new Size(143, 25);
            btn_showdocuments_T.TabIndex = 2;
            btn_showdocuments_T.Text = "Consultar Documentos";
            btn_showdocuments_T.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(8, 151);
            btn_logout.Margin = new Padding(2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(63, 25);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "LOGOUT";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_showexpenses
            // 
            btn_showexpenses.Location = new Point(12, 35);
            btn_showexpenses.Name = "btn_showexpenses";
            btn_showexpenses.Size = new Size(139, 23);
            btn_showexpenses.TabIndex = 4;
            btn_showexpenses.Text = "Consultar Despesas";
            btn_showexpenses.UseVisualStyleBackColor = true;
            btn_showexpenses.Click += btn_showexpenses_Click;
            // 
            // FormTenants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(370, 187);
            Controls.Add(btn_showexpenses);
            Controls.Add(btn_logout);
            Controls.Add(btn_showdocuments_T);
            Controls.Add(btn_showincomes_T);
            Controls.Add(btn_showcontracts_T);
            Name = "FormTenants";
            Text = "FormTenants";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_showcontracts_T;
        private Button btn_showincomes_T;
        private Button btn_showdocuments_T;
        private Button btn_logout;
        private Button btn_showexpenses;
    }
}