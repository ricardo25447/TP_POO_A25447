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
            listview_properties.Location = new Point(14, 16);
            listview_properties.Margin = new Padding(3, 4, 3, 4);
            listview_properties.Name = "listview_properties";
            listview_properties.Size = new Size(747, 356);
            listview_properties.TabIndex = 0;
            listview_properties.UseCompatibleStateImageBehavior = false;
            // 
            // btn_addcontract
            // 
            btn_addcontract.Location = new Point(14, 448);
            btn_addcontract.Margin = new Padding(3, 4, 3, 4);
            btn_addcontract.Name = "btn_addcontract";
            btn_addcontract.Size = new Size(113, 31);
            btn_addcontract.TabIndex = 1;
            btn_addcontract.Text = "ADICIONAR CONTRATO";
            btn_addcontract.UseVisualStyleBackColor = true;
            btn_addcontract.Click += btn_addcontract_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(257, 448);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 31);
            btn_back.TabIndex = 2;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_activecontracts
            // 
            btn_activecontracts.Location = new Point(133, 448);
            btn_activecontracts.Margin = new Padding(3, 4, 3, 4);
            btn_activecontracts.Name = "btn_activecontracts";
            btn_activecontracts.Size = new Size(118, 31);
            btn_activecontracts.TabIndex = 3;
            btn_activecontracts.Text = "CONTRATOS ATIVOS";
            btn_activecontracts.UseVisualStyleBackColor = true;
            btn_activecontracts.Click += btn_activecontracts_Click;
            // 
            // AssociateProperties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(776, 495);
            Controls.Add(btn_activecontracts);
            Controls.Add(btn_back);
            Controls.Add(btn_addcontract);
            Controls.Add(listview_properties);
            Margin = new Padding(3, 4, 3, 4);
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