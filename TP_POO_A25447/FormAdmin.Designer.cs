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
            SuspendLayout();
            // 
            // btn_showcontracts
            // 
            btn_showcontracts.Location = new Point(12, 12);
            btn_showcontracts.Name = "btn_showcontracts";
            btn_showcontracts.Size = new Size(75, 23);
            btn_showcontracts.TabIndex = 0;
            btn_showcontracts.Text = "Contratos";
            btn_showcontracts.UseVisualStyleBackColor = true;
            btn_showcontracts.Click += btn_showcontracts_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_showcontracts);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_showcontracts;
    }
}