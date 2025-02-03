namespace TP_POO_A25447
{
    partial class ManagePersonsForm
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
            btn_createaccount = new Button();
            btn_removeaccount = new Button();
            btn_listaccount = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_createaccount
            // 
            btn_createaccount.Location = new Point(12, 12);
            btn_createaccount.Name = "btn_createaccount";
            btn_createaccount.Size = new Size(156, 34);
            btn_createaccount.TabIndex = 0;
            btn_createaccount.Text = "Criar Conta";
            btn_createaccount.UseVisualStyleBackColor = true;
            btn_createaccount.Click += btn_createaccount_Click;
            // 
            // btn_removeaccount
            // 
            btn_removeaccount.Location = new Point(12, 52);
            btn_removeaccount.Name = "btn_removeaccount";
            btn_removeaccount.Size = new Size(156, 34);
            btn_removeaccount.TabIndex = 1;
            btn_removeaccount.Text = "Remover Conta";
            btn_removeaccount.UseVisualStyleBackColor = true;
            btn_removeaccount.Click += btn_removeaccount_Click;
            // 
            // btn_listaccount
            // 
            btn_listaccount.Location = new Point(12, 92);
            btn_listaccount.Name = "btn_listaccount";
            btn_listaccount.Size = new Size(156, 34);
            btn_listaccount.TabIndex = 2;
            btn_listaccount.Text = "Consultar Contas";
            btn_listaccount.UseVisualStyleBackColor = true;
            btn_listaccount.Click += btn_listaccount_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 176);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(87, 33);
            btn_back.TabIndex = 3;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ManagePersonsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(403, 221);
            Controls.Add(btn_back);
            Controls.Add(btn_listaccount);
            Controls.Add(btn_removeaccount);
            Controls.Add(btn_createaccount);
            Name = "ManagePersonsForm";
            Text = "ManagePersonsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_createaccount;
        private Button btn_removeaccount;
        private Button btn_listaccount;
        private Button btn_back;
    }
}