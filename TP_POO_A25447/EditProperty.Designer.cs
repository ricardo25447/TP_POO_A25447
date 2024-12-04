namespace TP_POO_A25447
{
    partial class EditProperty
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
            listview_editproperties = new ListView();
            btn_editproperty = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // listview_editproperties
            // 
            listview_editproperties.Location = new Point(12, 12);
            listview_editproperties.Name = "listview_editproperties";
            listview_editproperties.Size = new Size(531, 337);
            listview_editproperties.TabIndex = 0;
            listview_editproperties.UseCompatibleStateImageBehavior = false;
            // 
            // btn_editproperty
            // 
            btn_editproperty.Location = new Point(12, 376);
            btn_editproperty.Name = "btn_editproperty";
            btn_editproperty.Size = new Size(63, 24);
            btn_editproperty.TabIndex = 1;
            btn_editproperty.Text = "EDITAR";
            btn_editproperty.UseVisualStyleBackColor = true;
            btn_editproperty.Click += btn_editproperty_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(81, 376);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(56, 24);
            btn_back.TabIndex = 2;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // EditProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(559, 412);
            Controls.Add(btn_back);
            Controls.Add(btn_editproperty);
            Controls.Add(listview_editproperties);
            Name = "EditProperty";
            Text = "EditProperty";
            ResumeLayout(false);
        }

        #endregion

        private ListView listview_editproperties;
        private Button btn_editproperty;
        private Button btn_back;
    }
}