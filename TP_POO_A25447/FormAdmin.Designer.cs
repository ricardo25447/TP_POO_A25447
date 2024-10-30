namespace TP_POO_A25447
{
    partial class FormAdmin
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
            btn_showcontracts = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_showcontracts
            // 
            btn_showcontracts.Location = new Point(17, 20);
            btn_showcontracts.Margin = new Padding(4, 5, 4, 5);
            btn_showcontracts.Name = "btn_showcontracts";
            btn_showcontracts.Size = new Size(207, 38);
            btn_showcontracts.TabIndex = 0;
            btn_showcontracts.Text = "Gestão de Contratos";
            btn_showcontracts.UseVisualStyleBackColor = true;
            btn_showcontracts.Click += btn_showcontracts_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 66);
            button1.Name = "button1";
            button1.Size = new Size(207, 38);
            button1.TabIndex = 1;
            button1.Text = "Gestão de Imóveis";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(17, 110);
            button2.Name = "button2";
            button2.Size = new Size(207, 38);
            button2.TabIndex = 2;
            button2.Text = "Gestão de Inquilinos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(17, 154);
            button3.Name = "button3";
            button3.Size = new Size(207, 38);
            button3.TabIndex = 3;
            button3.Text = "Gestão de Documentos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(17, 198);
            button4.Name = "button4";
            button4.Size = new Size(207, 38);
            button4.TabIndex = 4;
            button4.Text = "Gestão de Despesas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(17, 242);
            button5.Name = "button5";
            button5.Size = new Size(207, 38);
            button5.TabIndex = 5;
            button5.Text = "Gestão de Rendas";
            button5.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(17, 328);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 34);
            btn_back.TabIndex = 6;
            btn_back.Text = "LOGOUT";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(545, 374);
            Controls.Add(btn_back);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_showcontracts);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_showcontracts;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn_back;
    }
}