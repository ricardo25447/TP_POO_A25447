namespace TP_POO_A25447
{
    partial class TenantContract
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
            lbl_inquilino = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_tenant = new TextBox();
            txt_tenantcc = new TextBox();
            datetime_startcontract = new DateTimePicker();
            datetime_endcontract = new DateTimePicker();
            btn_addcontract = new Button();
            btn_back = new Button();
            label1 = new Label();
            txt_selectedproperty = new TextBox();
            SuspendLayout();
            // 
            // lbl_inquilino
            // 
            lbl_inquilino.AutoSize = true;
            lbl_inquilino.Location = new Point(12, 50);
            lbl_inquilino.Name = "lbl_inquilino";
            lbl_inquilino.Size = new Size(54, 15);
            lbl_inquilino.TabIndex = 0;
            lbl_inquilino.Text = "Inquilino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nº CC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Início";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Fim";
            // 
            // txt_tenant
            // 
            txt_tenant.Location = new Point(81, 42);
            txt_tenant.Name = "txt_tenant";
            txt_tenant.Size = new Size(200, 23);
            txt_tenant.TabIndex = 4;
            txt_tenant.TextChanged += txt_tenant_TextChanged;
            // 
            // txt_tenantcc
            // 
            txt_tenantcc.Location = new Point(81, 78);
            txt_tenantcc.Name = "txt_tenantcc";
            txt_tenantcc.Size = new Size(200, 23);
            txt_tenantcc.TabIndex = 5;
            // 
            // datetime_startcontract
            // 
            datetime_startcontract.Location = new Point(81, 116);
            datetime_startcontract.Name = "datetime_startcontract";
            datetime_startcontract.Size = new Size(200, 23);
            datetime_startcontract.TabIndex = 6;
            // 
            // datetime_endcontract
            // 
            datetime_endcontract.Location = new Point(81, 153);
            datetime_endcontract.Name = "datetime_endcontract";
            datetime_endcontract.Size = new Size(200, 23);
            datetime_endcontract.TabIndex = 7;
            // 
            // btn_addcontract
            // 
            btn_addcontract.Location = new Point(12, 213);
            btn_addcontract.Name = "btn_addcontract";
            btn_addcontract.Size = new Size(82, 23);
            btn_addcontract.TabIndex = 8;
            btn_addcontract.Text = "ADICIONAR";
            btn_addcontract.UseVisualStyleBackColor = true;
            btn_addcontract.Click += btn_addcontract_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(100, 213);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(82, 23);
            btn_back.TabIndex = 9;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 10;
            label1.Text = "Imóvel";
            // 
            // txt_selectedproperty
            // 
            txt_selectedproperty.Location = new Point(81, 9);
            txt_selectedproperty.Name = "txt_selectedproperty";
            txt_selectedproperty.Size = new Size(200, 23);
            txt_selectedproperty.TabIndex = 11;
            // 
            // TenantContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(405, 248);
            Controls.Add(txt_selectedproperty);
            Controls.Add(label1);
            Controls.Add(btn_back);
            Controls.Add(btn_addcontract);
            Controls.Add(datetime_endcontract);
            Controls.Add(datetime_startcontract);
            Controls.Add(txt_tenantcc);
            Controls.Add(txt_tenant);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_inquilino);
            Name = "TenantContract";
            Text = "TenantContract";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_inquilino;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_tenant;
        private TextBox txt_tenantcc;
        private DateTimePicker datetime_startcontract;
        private DateTimePicker datetime_endcontract;
        private Button btn_addcontract;
        private Button btn_back;
        private Label label1;
        private TextBox txt_selectedproperty;
    }
}