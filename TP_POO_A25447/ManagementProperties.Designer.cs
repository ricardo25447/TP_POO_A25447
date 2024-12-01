namespace TP_POO_A25447
{
    partial class ManagementProperties
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
            btn_addproperty = new Button();
            btn_deleteproperty = new Button();
            btn_editproperty = new Button();
            btn_back = new Button();
            btn_listproperties = new Button();
            fontDialog1 = new FontDialog();
            SuspendLayout();
            // 
            // btn_addproperty
            // 
            btn_addproperty.Location = new Point(12, 15);
            btn_addproperty.Name = "btn_addproperty";
            btn_addproperty.Size = new Size(119, 29);
            btn_addproperty.TabIndex = 0;
            btn_addproperty.Text = "Adicionar Imóvel";
            btn_addproperty.UseVisualStyleBackColor = true;
            btn_addproperty.Click += btn_addproperty_Click;
            // 
            // btn_deleteproperty
            // 
            btn_deleteproperty.Location = new Point(12, 50);
            btn_deleteproperty.Name = "btn_deleteproperty";
            btn_deleteproperty.Size = new Size(119, 29);
            btn_deleteproperty.TabIndex = 1;
            btn_deleteproperty.Text = "Eliminar Imóvel";
            btn_deleteproperty.UseVisualStyleBackColor = true;
            btn_deleteproperty.Click += btn_deleteproperty_Click;
            // 
            // btn_editproperty
            // 
            btn_editproperty.Location = new Point(12, 85);
            btn_editproperty.Name = "btn_editproperty";
            btn_editproperty.Size = new Size(119, 29);
            btn_editproperty.TabIndex = 2;
            btn_editproperty.Text = "Editar Imóvel";
            btn_editproperty.UseVisualStyleBackColor = true;
            btn_editproperty.Click += btn_editproperty_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 181);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(71, 29);
            btn_back.TabIndex = 3;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_listproperties
            // 
            btn_listproperties.BackColor = SystemColors.ButtonHighlight;
            btn_listproperties.Location = new Point(12, 120);
            btn_listproperties.Name = "btn_listproperties";
            btn_listproperties.Size = new Size(119, 29);
            btn_listproperties.TabIndex = 0;
            btn_listproperties.Text = "Consultar Imóveis";
            btn_listproperties.UseVisualStyleBackColor = false;
            btn_listproperties.Click += btn_listproperties_Click;
            // 
            // ManagementProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(497, 229);
            Controls.Add(btn_listproperties);
            Controls.Add(btn_back);
            Controls.Add(btn_editproperty);
            Controls.Add(btn_deleteproperty);
            Controls.Add(btn_addproperty);
            Name = "ManagementProperties";
            Text = "ManagementProperties";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_addproperty;
        private Button btn_deleteproperty;
        private Button btn_editproperty;
        private Button btn_back;
        private Button btn_listproperties;
        private FontDialog fontDialog1;
    }
}