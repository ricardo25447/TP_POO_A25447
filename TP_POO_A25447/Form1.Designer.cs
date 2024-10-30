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
            admin_checkbox = new CheckBox();
            btn_info = new Button();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(17, 15);
            lbl_user.Margin = new Padding(4, 0, 4, 0);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(87, 25);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Utilizador";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(17, 65);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(87, 25);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password";
            // 
            // txt_user
            // 
            txt_user.BackColor = SystemColors.HighlightText;
            txt_user.Location = new Point(107, 10);
            txt_user.Margin = new Padding(4, 5, 4, 5);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(184, 31);
            txt_user.TabIndex = 2;
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.HighlightText;
            txt_password.Location = new Point(107, 58);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(184, 31);
            txt_password.TabIndex = 3;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Window;
            btn_login.Location = new Point(17, 173);
            btn_login.Margin = new Padding(4, 5, 4, 5);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(107, 38);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.Window;
            btn_exit.Location = new Point(133, 173);
            btn_exit.Margin = new Padding(4, 5, 4, 5);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(107, 38);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "SAIR";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // admin_checkbox
            // 
            admin_checkbox.AutoSize = true;
            admin_checkbox.Location = new Point(299, 10);
            admin_checkbox.Margin = new Padding(4, 5, 4, 5);
            admin_checkbox.Name = "admin_checkbox";
            admin_checkbox.Size = new Size(127, 29);
            admin_checkbox.TabIndex = 6;
            admin_checkbox.Text = "SENHORIO";
            admin_checkbox.UseVisualStyleBackColor = true;
            admin_checkbox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(383, 173);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(146, 38);
            btn_info.TabIndex = 7;
            btn_info.Text = "INFORMAÇÃO";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(541, 235);
            Controls.Add(btn_info);
            Controls.Add(admin_checkbox);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(lbl_password);
            Controls.Add(lbl_user);
            Margin = new Padding(4, 5, 4, 5);
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
        private CheckBox admin_checkbox;
        private Button btn_info;
    }
}
