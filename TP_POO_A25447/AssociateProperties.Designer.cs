namespace TP_POO_A25447
{
    partial class AssociateProperties
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
            listview_properties = new ListView();
            btn_addcontract = new Button();
            btn_back = new Button();
            btn_activecontracts = new Button();
            SuspendLayout();
            // 
            // listview_properties
            // 
            listview_properties.Location = new Point(12, 12);
            listview_properties.Name = "listview_properties";
            listview_properties.Size = new Size(654, 268);
            listview_properties.TabIndex = 0;
            listview_properties.UseCompatibleStateImageBehavior = false;
            // 
            // btn_addcontract
            // 
            btn_addcontract.Location = new Point(12, 336);
            btn_addcontract.Name = "btn_addcontract";
            btn_addcontract.Size = new Size(146, 23);
            btn_addcontract.TabIndex = 1;
            btn_addcontract.Text = "ADICIONAR CONTRATO";
            btn_addcontract.UseVisualStyleBackColor = true;
            btn_addcontract.Click += btn_addcontract_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(296, 336);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 2;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_activecontracts
            // 
            btn_activecontracts.Location = new Point(164, 336);
            btn_activecontracts.Name = "btn_activecontracts";
            btn_activecontracts.Size = new Size(126, 23);
            btn_activecontracts.TabIndex = 3;
            btn_activecontracts.Text = "CONTRATOS ATIVOS";
            btn_activecontracts.UseVisualStyleBackColor = true;
            btn_activecontracts.Click += btn_activecontracts_Click;
            // 
            // AssociateProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(679, 371);
            Controls.Add(btn_activecontracts);
            Controls.Add(btn_back);
            Controls.Add(btn_addcontract);
            Controls.Add(listview_properties);
            Name = "AssociateProperties";
            Text = "AssociateProperties";
            ResumeLayout(false);
        }

        #endregion

        private ListView listview_properties;
        private Button btn_addcontract;
        private Button btn_back;
        private Button btn_activecontracts;
    }
}