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
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(12, 9);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(57, 15);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Utilizador";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(12, 39);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password";
            // 
            // txt_user
            // 
            txt_user.BackColor = SystemColors.HighlightText;
            txt_user.Location = new Point(75, 6);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(130, 23);
            txt_user.TabIndex = 2;
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.HighlightText;
            txt_password.Location = new Point(75, 35);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(130, 23);
            txt_password.TabIndex = 3;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Window;
            btn_login.Location = new Point(12, 104);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.Window;
            btn_exit.Location = new Point(93, 104);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Sair";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(321, 139);
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
    }
}
