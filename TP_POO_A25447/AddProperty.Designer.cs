namespace TP_POO_A25447
{
    partial class AddProperty
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
            label1 = new Label();
            label2 = new Label();
            txt_priceproperty = new TextBox();
            label3 = new Label();
            txt_incomeproperty = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dropdown_typeproperty = new ComboBox();
            txt_districtproperty = new TextBox();
            txt_municipalityproperty = new TextBox();
            txt_parishproperty = new TextBox();
            btn_addproperty = new Button();
            btn_back = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_inquilinoproperty = new TextBox();
            txt_ccusername = new Label();
            txt_propertyusercc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Propriedade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço da Propriedade";
            // 
            // txt_priceproperty
            // 
            txt_priceproperty.Location = new Point(158, 35);
            txt_priceproperty.Name = "txt_priceproperty";
            txt_priceproperty.Size = new Size(138, 23);
            txt_priceproperty.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 4;
            label3.Text = "Renda da Propriedade";
            // 
            // txt_incomeproperty
            // 
            txt_incomeproperty.Location = new Point(158, 64);
            txt_incomeproperty.Name = "txt_incomeproperty";
            txt_incomeproperty.Size = new Size(138, 23);
            txt_incomeproperty.TabIndex = 3;
            txt_incomeproperty.TextChanged += txt_incomeproperty_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 6;
            label4.Text = "Distrito da Propriedade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 7;
            label5.Text = "Concelho da Propriedade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 8;
            label6.Text = "Freguesia da Propriedade";
            // 
            // dropdown_typeproperty
            // 
            dropdown_typeproperty.FormattingEnabled = true;
            dropdown_typeproperty.Location = new Point(158, 6);
            dropdown_typeproperty.Name = "dropdown_typeproperty";
            dropdown_typeproperty.Size = new Size(138, 23);
            dropdown_typeproperty.TabIndex = 1;
            dropdown_typeproperty.SelectedIndexChanged += dropdown_typeproperty_SelectedIndexChanged;
            // 
            // txt_districtproperty
            // 
            txt_districtproperty.Location = new Point(158, 92);
            txt_districtproperty.Name = "txt_districtproperty";
            txt_districtproperty.Size = new Size(138, 23);
            txt_districtproperty.TabIndex = 4;
            // 
            // txt_municipalityproperty
            // 
            txt_municipalityproperty.Location = new Point(158, 122);
            txt_municipalityproperty.Name = "txt_municipalityproperty";
            txt_municipalityproperty.Size = new Size(138, 23);
            txt_municipalityproperty.TabIndex = 5;
            // 
            // txt_parishproperty
            // 
            txt_parishproperty.Location = new Point(158, 152);
            txt_parishproperty.Name = "txt_parishproperty";
            txt_parishproperty.Size = new Size(138, 23);
            txt_parishproperty.TabIndex = 6;
            // 
            // btn_addproperty
            // 
            btn_addproperty.Location = new Point(12, 268);
            btn_addproperty.Name = "btn_addproperty";
            btn_addproperty.Size = new Size(83, 23);
            btn_addproperty.TabIndex = 8;
            btn_addproperty.Text = "ADICIONAR";
            btn_addproperty.UseVisualStyleBackColor = true;
            btn_addproperty.Click += btn_addproperty_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(101, 268);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(83, 23);
            btn_back.TabIndex = 9;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 67);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 10;
            label7.Text = "€/mês";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(302, 41);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 11;
            label8.Text = "€";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 187);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 12;
            label9.Text = "Inquilino";
            // 
            // txt_inquilinoproperty
            // 
            txt_inquilinoproperty.Location = new Point(158, 184);
            txt_inquilinoproperty.Name = "txt_inquilinoproperty";
            txt_inquilinoproperty.Size = new Size(138, 23);
            txt_inquilinoproperty.TabIndex = 7;
            // 
            // txt_ccusername
            // 
            txt_ccusername.AutoSize = true;
            txt_ccusername.Location = new Point(12, 217);
            txt_ccusername.Name = "txt_ccusername";
            txt_ccusername.Size = new Size(87, 15);
            txt_ccusername.TabIndex = 13;
            txt_ccusername.Text = "Número do CC";
            // 
            // txt_propertyusercc
            // 
            txt_propertyusercc.Location = new Point(158, 214);
            txt_propertyusercc.Name = "txt_propertyusercc";
            txt_propertyusercc.Size = new Size(138, 23);
            txt_propertyusercc.TabIndex = 14;
            // 
            // AddProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(466, 303);
            Controls.Add(txt_propertyusercc);
            Controls.Add(txt_ccusername);
            Controls.Add(txt_inquilinoproperty);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_back);
            Controls.Add(btn_addproperty);
            Controls.Add(txt_parishproperty);
            Controls.Add(txt_municipalityproperty);
            Controls.Add(txt_districtproperty);
            Controls.Add(dropdown_typeproperty);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_incomeproperty);
            Controls.Add(label3);
            Controls.Add(txt_priceproperty);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProperty";
            Text = "Adicionar Nova Propriedade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_priceproperty;
        private Label label3;
        private TextBox txt_incomeproperty;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox dropdown_typeproperty;
        private TextBox txt_districtproperty;
        private TextBox txt_municipalityproperty;
        private TextBox txt_parishproperty;
        private Button btn_addproperty;
        private Button btn_back;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_inquilinoproperty;
        private Label txt_ccusername;
        private TextBox txt_propertyusercc;
    }
}