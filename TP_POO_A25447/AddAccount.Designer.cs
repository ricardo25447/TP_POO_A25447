namespace TP_POO_A25447
{
    partial class AddAccount
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
            lbl_adduser = new Label();
            lbl_addpassword = new Label();
            addpassword_txt = new TextBox();
            adduser_txt = new TextBox();
            btn_addaccount = new Button();
            btn_back_addaccount = new Button();
            SuspendLayout();
            // 
            // lbl_adduser
            // 
            lbl_adduser.AutoSize = true;
            lbl_adduser.ForeColor = SystemColors.ActiveCaptionText;
            lbl_adduser.Location = new Point(12, 9);
            lbl_adduser.Name = "lbl_adduser";
            lbl_adduser.Size = new Size(91, 25);
            lbl_adduser.TabIndex = 0;
            lbl_adduser.Text = "Username";
            // 
            // lbl_addpassword
            // 
            lbl_addpassword.AutoSize = true;
            lbl_addpassword.ForeColor = SystemColors.ActiveCaptionText;
            lbl_addpassword.Location = new Point(16, 48);
            lbl_addpassword.Name = "lbl_addpassword";
            lbl_addpassword.Size = new Size(87, 25);
            lbl_addpassword.TabIndex = 1;
            lbl_addpassword.Text = "Password";
            // 
            // addpassword_txt
            // 
            addpassword_txt.Location = new Point(109, 48);
            addpassword_txt.Multiline = true;
            addpassword_txt.Name = "addpassword_txt";
            addpassword_txt.Size = new Size(159, 33);
            addpassword_txt.TabIndex = 2;
            addpassword_txt.TextChanged += addpassword_txt_TextChanged;
            // 
            // adduser_txt
            // 
            adduser_txt.Location = new Point(109, 9);
            adduser_txt.Multiline = true;
            adduser_txt.Name = "adduser_txt";
            adduser_txt.Size = new Size(159, 33);
            adduser_txt.TabIndex = 3;
            adduser_txt.TextChanged += adduser_txt_TextChanged;
            // 
            // btn_addaccount
            // 
            btn_addaccount.ForeColor = SystemColors.ActiveCaptionText;
            btn_addaccount.Location = new Point(12, 136);
            btn_addaccount.Name = "btn_addaccount";
            btn_addaccount.Size = new Size(128, 34);
            btn_addaccount.TabIndex = 4;
            btn_addaccount.Text = "ADICIONAR";
            btn_addaccount.UseVisualStyleBackColor = true;
            btn_addaccount.Click += btn_addaccount_Click;
            // 
            // btn_back_addaccount
            // 
            btn_back_addaccount.ForeColor = SystemColors.ActiveCaptionText;
            btn_back_addaccount.Location = new Point(146, 136);
            btn_back_addaccount.Name = "btn_back_addaccount";
            btn_back_addaccount.Size = new Size(112, 34);
            btn_back_addaccount.TabIndex = 5;
            btn_back_addaccount.Text = "VOLTAR";
            btn_back_addaccount.UseVisualStyleBackColor = true;
            btn_back_addaccount.Click += btn_back_addaccount_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(477, 192);
            Controls.Add(btn_back_addaccount);
            Controls.Add(btn_addaccount);
            Controls.Add(adduser_txt);
            Controls.Add(addpassword_txt);
            Controls.Add(lbl_addpassword);
            Controls.Add(lbl_adduser);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "AddAccount";
            Text = "AddAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_adduser;
        private Label lbl_addpassword;
        private TextBox addpassword_txt;
        private TextBox adduser_txt;
        private Button btn_addaccount;
        private Button btn_back_addaccount;
    }
}