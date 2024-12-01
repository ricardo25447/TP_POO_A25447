namespace TP_POO_A25447
{
    partial class RemoveProperties
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
            checkedListBoxProperties = new ListBox();
            btn_removeproperty = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // checkedListBoxProperties
            // 
            checkedListBoxProperties.ItemHeight = 15;
            checkedListBoxProperties.Location = new Point(12, 12);
            checkedListBoxProperties.Name = "checkedListBoxProperties";
            checkedListBoxProperties.Size = new Size(967, 274);
            checkedListBoxProperties.TabIndex = 1;
            checkedListBoxProperties.SelectedIndexChanged += checkedListBoxProperties_SelectedIndexChanged;
            // 
            // btn_removeproperty
            // 
            btn_removeproperty.BackColor = SystemColors.ButtonHighlight;
            btn_removeproperty.Location = new Point(12, 302);
            btn_removeproperty.Name = "btn_removeproperty";
            btn_removeproperty.Size = new Size(75, 23);
            btn_removeproperty.TabIndex = 0;
            btn_removeproperty.Text = "REMOVER";
            btn_removeproperty.UseVisualStyleBackColor = false;
            btn_removeproperty.Click += btn_removeproperty_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(93, 302);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 2;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // RemoveProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(990, 338);
            Controls.Add(btn_back);
            Controls.Add(btn_removeproperty);
            Controls.Add(checkedListBoxProperties);
            Name = "RemoveProperties";
            Text = "RemoveProperties";
            Load += RemoveProperties_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox checkedListBoxProperties;
        private Button btn_removeproperty;
        private Button btn_back;
    }
}