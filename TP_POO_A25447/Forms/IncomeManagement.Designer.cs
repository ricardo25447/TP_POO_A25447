namespace TP_POO_A25447
{
    partial class IncomeManagement
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
            btn_showincomes = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // listview_properties
            // 
            listview_properties.Location = new Point(12, 12);
            listview_properties.Name = "listview_properties";
            listview_properties.Size = new Size(597, 297);
            listview_properties.TabIndex = 0;
            listview_properties.UseCompatibleStateImageBehavior = false;
            // 
            // btn_showincomes
            // 
            btn_showincomes.Location = new Point(12, 337);
            btn_showincomes.Name = "btn_showincomes";
            btn_showincomes.Size = new Size(89, 23);
            btn_showincomes.TabIndex = 1;
            btn_showincomes.Text = "VER RENDAS";
            btn_showincomes.UseVisualStyleBackColor = true;
            btn_showincomes.Click += btn_showincomes_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(107, 337);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 2;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // IncomeManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 372);
            Controls.Add(btn_back);
            Controls.Add(btn_showincomes);
            Controls.Add(listview_properties);
            Name = "IncomeManagement";
            Text = "IncomeManagement";
            ResumeLayout(false);
        }

        #endregion

        private ListView listview_properties;
        private Button btn_showincomes;
        private Button btn_back;
    }
}