namespace TP_POO_A25447
{
    partial class FormAdmin
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
            btn_showcontracts = new Button();
            btn_showproperty = new Button();
            btn_showdocuments = new Button();
            btn_showexpenses = new Button();
            btn_showincomes = new Button();
            btn_back = new Button();
            btn_managepersons = new Button();
            SuspendLayout();
            // 
            // btn_showcontracts
            // 
            btn_showcontracts.Location = new Point(12, 12);
            btn_showcontracts.Name = "btn_showcontracts";
            btn_showcontracts.Size = new Size(145, 23);
            btn_showcontracts.TabIndex = 0;
            btn_showcontracts.Text = "Gestão de Contratos";
            btn_showcontracts.UseVisualStyleBackColor = true;
            btn_showcontracts.Click += btn_showcontracts_Click;
            // 
            // btn_showproperty
            // 
            btn_showproperty.Location = new Point(12, 40);
            btn_showproperty.Margin = new Padding(2);
            btn_showproperty.Name = "btn_showproperty";
            btn_showproperty.Size = new Size(145, 23);
            btn_showproperty.TabIndex = 1;
            btn_showproperty.Text = "Gestão de Imóveis";
            btn_showproperty.UseVisualStyleBackColor = true;
            btn_showproperty.Click += btn_showproperty_Click;
            // 
            // btn_showdocuments
            // 
            btn_showdocuments.Location = new Point(12, 67);
            btn_showdocuments.Margin = new Padding(2);
            btn_showdocuments.Name = "btn_showdocuments";
            btn_showdocuments.Size = new Size(145, 23);
            btn_showdocuments.TabIndex = 3;
            btn_showdocuments.Text = "Gestão de Documentos";
            btn_showdocuments.UseVisualStyleBackColor = true;
            // 
            // btn_showexpenses
            // 
            btn_showexpenses.Location = new Point(12, 94);
            btn_showexpenses.Margin = new Padding(2);
            btn_showexpenses.Name = "btn_showexpenses";
            btn_showexpenses.Size = new Size(145, 23);
            btn_showexpenses.TabIndex = 4;
            btn_showexpenses.Text = "Gestão de Despesas";
            btn_showexpenses.UseVisualStyleBackColor = true;
            // 
            // btn_showincomes
            // 
            btn_showincomes.Location = new Point(12, 121);
            btn_showincomes.Margin = new Padding(2);
            btn_showincomes.Name = "btn_showincomes";
            btn_showincomes.Size = new Size(145, 23);
            btn_showincomes.TabIndex = 5;
            btn_showincomes.Text = "Gestão de Rendas";
            btn_showincomes.UseVisualStyleBackColor = true;
            btn_showincomes.Click += btn_showincomes_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(11, 205);
            btn_back.Margin = new Padding(2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(78, 23);
            btn_back.TabIndex = 6;
            btn_back.Text = "LOGOUT";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_managepersons
            // 
            btn_managepersons.Location = new Point(12, 148);
            btn_managepersons.Margin = new Padding(2);
            btn_managepersons.Name = "btn_managepersons";
            btn_managepersons.Size = new Size(145, 23);
            btn_managepersons.TabIndex = 7;
            btn_managepersons.Text = "Gestão de Pessoas";
            btn_managepersons.UseVisualStyleBackColor = true;
            btn_managepersons.Click += managepersons_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(359, 235);
            Controls.Add(btn_managepersons);
            Controls.Add(btn_back);
            Controls.Add(btn_showincomes);
            Controls.Add(btn_showexpenses);
            Controls.Add(btn_showdocuments);
            Controls.Add(btn_showproperty);
            Controls.Add(btn_showcontracts);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_showcontracts;
        private Button btn_showproperty;
        private Button btn_showdocuments;
        private Button btn_showexpenses;
        private Button btn_showincomes;
        private Button btn_back;
        private Button managepersons;
        private Button btn_managepersons;
    }
}