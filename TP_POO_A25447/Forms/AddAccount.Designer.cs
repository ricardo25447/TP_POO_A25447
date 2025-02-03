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
            label1 = new Label();
            txt_ccnumber = new TextBox();
            SuspendLayout();
            // 
            // lbl_adduser
            // 
            lbl_adduser.AutoSize = true;
            lbl_adduser.ForeColor = SystemColors.ActiveCaptionText;
            lbl_adduser.Location = new Point(8, 5);
            lbl_adduser.Margin = new Padding(2, 0, 2, 0);
            lbl_adduser.Name = "lbl_adduser";
            lbl_adduser.Size = new Size(60, 15);
            lbl_adduser.TabIndex = 0;
            lbl_adduser.Text = "Username";
            // 
            // lbl_addpassword
            // 
            lbl_addpassword.AutoSize = true;
            lbl_addpassword.ForeColor = SystemColors.ActiveCaptionText;
            lbl_addpassword.Location = new Point(12, 29);
            lbl_addpassword.Margin = new Padding(2, 0, 2, 0);
            lbl_addpassword.Name = "lbl_addpassword";
            lbl_addpassword.Size = new Size(57, 15);
            lbl_addpassword.TabIndex = 1;
            lbl_addpassword.Text = "Password";
            // 
            // addpassword_txt
            // 
            addpassword_txt.Location = new Point(76, 29);
            addpassword_txt.Margin = new Padding(2);
            addpassword_txt.Multiline = true;
            addpassword_txt.Name = "addpassword_txt";
            addpassword_txt.Size = new Size(112, 21);
            addpassword_txt.TabIndex = 2;
            addpassword_txt.TextChanged += addpassword_txt_TextChanged;
            // 
            // adduser_txt
            // 
            adduser_txt.Location = new Point(76, 5);
            adduser_txt.Margin = new Padding(2);
            adduser_txt.Multiline = true;
            adduser_txt.Name = "adduser_txt";
            adduser_txt.Size = new Size(112, 21);
            adduser_txt.TabIndex = 1;
            adduser_txt.TextChanged += adduser_txt_TextChanged;
            // 
            // btn_addaccount
            // 
            btn_addaccount.ForeColor = SystemColors.ActiveCaptionText;
            btn_addaccount.Location = new Point(8, 127);
            btn_addaccount.Margin = new Padding(2);
            btn_addaccount.Name = "btn_addaccount";
            btn_addaccount.Size = new Size(90, 23);
            btn_addaccount.TabIndex = 4;
            btn_addaccount.Text = "ADICIONAR";
            btn_addaccount.UseVisualStyleBackColor = true;
            btn_addaccount.Click += btn_addaccount_Click;
            // 
            // btn_back_addaccount
            // 
            btn_back_addaccount.ForeColor = SystemColors.ActiveCaptionText;
            btn_back_addaccount.Location = new Point(102, 127);
            btn_back_addaccount.Margin = new Padding(2);
            btn_back_addaccount.Name = "btn_back_addaccount";
            btn_back_addaccount.Size = new Size(78, 23);
            btn_back_addaccount.TabIndex = 5;
            btn_back_addaccount.Text = "VOLTAR";
            btn_back_addaccount.UseVisualStyleBackColor = true;
            btn_back_addaccount.Click += btn_back_addaccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Nº CC";
            // 
            // txt_ccnumber
            // 
            txt_ccnumber.Location = new Point(76, 55);
            txt_ccnumber.Name = "txt_ccnumber";
            txt_ccnumber.Size = new Size(112, 23);
            txt_ccnumber.TabIndex = 3;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(334, 161);
            Controls.Add(txt_ccnumber);
            Controls.Add(label1);
            Controls.Add(btn_back_addaccount);
            Controls.Add(btn_addaccount);
            Controls.Add(adduser_txt);
            Controls.Add(addpassword_txt);
            Controls.Add(lbl_addpassword);
            Controls.Add(lbl_adduser);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(2);
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
        private Label label1;
        private TextBox txt_ccnumber;
    }
}