namespace TP_POO_A25447
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_user = new Label();
            lbl_password = new Label();
            txt_user = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            btn_info = new Button();
            label1 = new Label();
            cc_txt = new TextBox();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(12, 9);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(62, 15);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Utilizador*";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(12, 39);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(62, 15);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password*";
            // 
            // txt_user
            // 
            txt_user.BackColor = SystemColors.HighlightText;
            txt_user.Location = new Point(75, 6);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(130, 23);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.HighlightText;
            txt_password.Location = new Point(75, 35);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(130, 23);
            txt_password.TabIndex = 2;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Window;
            btn_login.Location = new Point(12, 134);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.Enter += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.Window;
            btn_exit.Location = new Point(93, 134);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "SAIR";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(266, 135);
            btn_info.Margin = new Padding(2);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(102, 23);
            btn_info.TabIndex = 6;
            btn_info.Text = "INFORMAÇÃO";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Nº CC*";
            // 
            // cc_txt
            // 
            cc_txt.Location = new Point(75, 64);
            cc_txt.Name = "cc_txt";
            cc_txt.Size = new Size(130, 23);
            cc_txt.TabIndex = 3;
            cc_txt.TextChanged += cc_txt_TextChanged;
            // 
            // Form1
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(379, 169);
            Controls.Add(cc_txt);
            Controls.Add(label1);
            Controls.Add(btn_info);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(lbl_password);
            Controls.Add(lbl_user);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private Label lbl_password;
        private TextBox txt_user;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_exit;
        private Button btn_info;
        private Label label1;
        private TextBox cc_txt;
    }
}
