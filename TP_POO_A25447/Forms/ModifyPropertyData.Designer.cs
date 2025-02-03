namespace TP_POO_A25447
{
    partial class ModifyPropertyData
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
            btn_savenewdata = new Button();
            btn_back = new Button();
            combobox_typeproperty = new ComboBox();
            txt_priceproperty = new TextBox();
            txt_incomeproperty = new TextBox();
            txt_districtproperty = new TextBox();
            txt_municipalityproperty = new TextBox();
            txt_parishproperty = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_savenewdata
            // 
            btn_savenewdata.Location = new Point(14, 307);
            btn_savenewdata.Margin = new Padding(3, 4, 3, 4);
            btn_savenewdata.Name = "btn_savenewdata";
            btn_savenewdata.Size = new Size(205, 31);
            btn_savenewdata.TabIndex = 0;
            btn_savenewdata.Text = "GUARDAR NOVOS DADOS";
            btn_savenewdata.UseVisualStyleBackColor = true;
            btn_savenewdata.Click += btn_savenewdata_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(225, 307);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 31);
            btn_back.TabIndex = 1;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // combobox_typeproperty
            // 
            combobox_typeproperty.FormattingEnabled = true;
            combobox_typeproperty.Location = new Point(158, 20);
            combobox_typeproperty.Margin = new Padding(3, 4, 3, 4);
            combobox_typeproperty.Name = "combobox_typeproperty";
            combobox_typeproperty.Size = new Size(179, 28);
            combobox_typeproperty.TabIndex = 2;
            // 
            // txt_priceproperty
            // 
            txt_priceproperty.Location = new Point(158, 58);
            txt_priceproperty.Margin = new Padding(3, 4, 3, 4);
            txt_priceproperty.Name = "txt_priceproperty";
            txt_priceproperty.Size = new Size(179, 27);
            txt_priceproperty.TabIndex = 3;
            txt_priceproperty.KeyPress += txt_priceproperty_KeyPress;
            // 
            // txt_incomeproperty
            // 
            txt_incomeproperty.Location = new Point(158, 94);
            txt_incomeproperty.Margin = new Padding(3, 4, 3, 4);
            txt_incomeproperty.Name = "txt_incomeproperty";
            txt_incomeproperty.Size = new Size(179, 27);
            txt_incomeproperty.TabIndex = 4;
            txt_incomeproperty.KeyPress += txt_incomeproperty_KeyPress;
            // 
            // txt_districtproperty
            // 
            txt_districtproperty.Location = new Point(158, 133);
            txt_districtproperty.Margin = new Padding(3, 4, 3, 4);
            txt_districtproperty.Name = "txt_districtproperty";
            txt_districtproperty.Size = new Size(179, 27);
            txt_districtproperty.TabIndex = 5;
            // 
            // txt_municipalityproperty
            // 
            txt_municipalityproperty.Location = new Point(158, 172);
            txt_municipalityproperty.Margin = new Padding(3, 4, 3, 4);
            txt_municipalityproperty.Name = "txt_municipalityproperty";
            txt_municipalityproperty.Size = new Size(179, 27);
            txt_municipalityproperty.TabIndex = 6;
            // 
            // txt_parishproperty
            // 
            txt_parishproperty.Location = new Point(158, 207);
            txt_parishproperty.Margin = new Padding(3, 4, 3, 4);
            txt_parishproperty.Name = "txt_parishproperty";
            txt_parishproperty.Size = new Size(179, 27);
            txt_parishproperty.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Tipo de Imóvel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "Preço do Imóvel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 97);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 10;
            label3.Text = "Renda do Imóvel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 136);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 11;
            label4.Text = "Distrito do Imóvel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 175);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 12;
            label5.Text = "Concelho do Imóvel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 213);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 13;
            label6.Text = "Freguesia do Imóvel";
            // 
            // ModifyPropertyData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(489, 353);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_parishproperty);
            Controls.Add(txt_municipalityproperty);
            Controls.Add(txt_districtproperty);
            Controls.Add(txt_incomeproperty);
            Controls.Add(txt_priceproperty);
            Controls.Add(combobox_typeproperty);
            Controls.Add(btn_back);
            Controls.Add(btn_savenewdata);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModifyPropertyData";
            Text = "ModifyPropertyData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_savenewdata;
        private Button btn_back;
        private ComboBox combobox_typeproperty;
        private TextBox txt_priceproperty;
        private TextBox txt_incomeproperty;
        private TextBox txt_districtproperty;
        private TextBox txt_municipalityproperty;
        private TextBox txt_parishproperty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}