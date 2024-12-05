namespace TP_POO_A25447
{
    partial class ExpensesPropertycs
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
            listview_properties = new ListView();
            btn_addexpenses = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // listview_properties
            // 
            listview_properties.Location = new Point(12, 12);
            listview_properties.Name = "listview_properties";
            listview_properties.Size = new Size(591, 355);
            listview_properties.TabIndex = 0;
            listview_properties.UseCompatibleStateImageBehavior = false;
            // 
            // btn_addexpenses
            // 
            btn_addexpenses.Location = new Point(12, 387);
            btn_addexpenses.Name = "btn_addexpenses";
            btn_addexpenses.Size = new Size(131, 23);
            btn_addexpenses.TabIndex = 1;
            btn_addexpenses.Text = "ADICIONAR DESPESA";
            btn_addexpenses.UseVisualStyleBackColor = true;
            btn_addexpenses.Click += btn_addexpenses_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(149, 387);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(57, 23);
            btn_back.TabIndex = 2;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ExpensesPropertycs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(616, 422);
            Controls.Add(btn_back);
            Controls.Add(btn_addexpenses);
            Controls.Add(listview_properties);
            Name = "ExpensesPropertycs";
            Text = "ExpensesPropertycs";
            ResumeLayout(false);
        }

        #endregion

        private ListView listview_properties;
        private Button btn_addexpenses;
        private Button btn_back;
    }
}