﻿namespace TP_POO_A25447
{
    partial class RemoveAccountUser
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
            btn_removeuser = new Button();
            txt_removeuser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_ccremoveuser = new TextBox();
            btn_backaccountuser = new Button();
            SuspendLayout();
            // 
            // btn_removeuser
            // 
            btn_removeuser.Location = new Point(14, 111);
            btn_removeuser.Margin = new Padding(3, 4, 3, 4);
            btn_removeuser.Name = "btn_removeuser";
            btn_removeuser.Size = new Size(86, 31);
            btn_removeuser.TabIndex = 0;
            btn_removeuser.Text = "Remover";
            btn_removeuser.UseVisualStyleBackColor = true;
            btn_removeuser.Click += btn_removeuser_Click;
            // 
            // txt_removeuser
            // 
            txt_removeuser.Location = new Point(89, 8);
            txt_removeuser.Margin = new Padding(3, 4, 3, 4);
            txt_removeuser.Name = "txt_removeuser";
            txt_removeuser.Size = new Size(154, 27);
            txt_removeuser.TabIndex = 1;
            txt_removeuser.TextChanged += txt_removeuser_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Nº CC";
            // 
            // txt_ccremoveuser
            // 
            txt_ccremoveuser.Location = new Point(89, 46);
            txt_ccremoveuser.Margin = new Padding(3, 4, 3, 4);
            txt_ccremoveuser.Name = "txt_ccremoveuser";
            txt_ccremoveuser.Size = new Size(154, 27);
            txt_ccremoveuser.TabIndex = 4;
            // 
            // btn_backaccountuser
            // 
            btn_backaccountuser.Location = new Point(106, 111);
            btn_backaccountuser.Margin = new Padding(3, 4, 3, 4);
            btn_backaccountuser.Name = "btn_backaccountuser";
            btn_backaccountuser.Size = new Size(86, 31);
            btn_backaccountuser.TabIndex = 5;
            btn_backaccountuser.Text = "Voltar";
            btn_backaccountuser.UseVisualStyleBackColor = true;
            btn_backaccountuser.Click += btn_backaccountuser_Click;
            // 
            // RemoveAccountUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(369, 164);
            Controls.Add(btn_backaccountuser);
            Controls.Add(txt_ccremoveuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_removeuser);
            Controls.Add(btn_removeuser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RemoveAccountUser";
            Text = "RemoveAccountUser";
            Load += RemoveAccountUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_removeuser;
        private TextBox txt_removeuser;
        private Label label1;
        private Label label2;
        private TextBox txt_ccremoveuser;
        private Button btn_backaccountuser;
    }
}