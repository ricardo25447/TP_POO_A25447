namespace TP_POO_A25447
{
    partial class AddExpenses
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_descriptionexpense = new TextBox();
            txt_amountexpense = new TextBox();
            btn_saveexpense = new Button();
            btn_back = new Button();
            combobox_typeexpenses = new ComboBox();
            datetime_expense = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txt_sellectedproperty = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Despesa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 89);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição da Despesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantia da Despesa";
            // 
            // txt_descriptionexpense
            // 
            txt_descriptionexpense.Location = new Point(153, 85);
            txt_descriptionexpense.Margin = new Padding(3, 4, 3, 4);
            txt_descriptionexpense.Name = "txt_descriptionexpense";
            txt_descriptionexpense.Size = new Size(196, 27);
            txt_descriptionexpense.TabIndex = 4;
            // 
            // txt_amountexpense
            // 
            txt_amountexpense.Location = new Point(153, 124);
            txt_amountexpense.Margin = new Padding(3, 4, 3, 4);
            txt_amountexpense.Name = "txt_amountexpense";
            txt_amountexpense.Size = new Size(196, 27);
            txt_amountexpense.TabIndex = 5;
            txt_amountexpense.KeyPress += txt_amountexpense_KeyPress;
            // 
            // btn_saveexpense
            // 
            btn_saveexpense.Location = new Point(14, 249);
            btn_saveexpense.Margin = new Padding(3, 4, 3, 4);
            btn_saveexpense.Name = "btn_saveexpense";
            btn_saveexpense.Size = new Size(101, 31);
            btn_saveexpense.TabIndex = 6;
            btn_saveexpense.Text = "REGISTAR DESPESA";
            btn_saveexpense.UseVisualStyleBackColor = true;
            btn_saveexpense.Click += btn_saveexpense_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(121, 249);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 31);
            btn_back.TabIndex = 7;
            btn_back.Text = "VOLTAR";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // combobox_typeexpenses
            // 
            combobox_typeexpenses.FormattingEnabled = true;
            combobox_typeexpenses.Location = new Point(153, 47);
            combobox_typeexpenses.Margin = new Padding(3, 4, 3, 4);
            combobox_typeexpenses.Name = "combobox_typeexpenses";
            combobox_typeexpenses.Size = new Size(196, 28);
            combobox_typeexpenses.TabIndex = 8;
            // 
            // datetime_expense
            // 
            datetime_expense.Location = new Point(153, 163);
            datetime_expense.Margin = new Padding(3, 4, 3, 4);
            datetime_expense.Name = "datetime_expense";
            datetime_expense.Size = new Size(196, 27);
            datetime_expense.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 173);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 10;
            label4.Text = "Data Despesa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 19);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 11;
            label5.Text = "Imóvel";
            // 
            // txt_sellectedproperty
            // 
            txt_sellectedproperty.Location = new Point(153, 8);
            txt_sellectedproperty.Margin = new Padding(3, 4, 3, 4);
            txt_sellectedproperty.Name = "txt_sellectedproperty";
            txt_sellectedproperty.Size = new Size(196, 27);
            txt_sellectedproperty.TabIndex = 12;
            // 
            // AddExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(450, 301);
            Controls.Add(txt_sellectedproperty);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(datetime_expense);
            Controls.Add(combobox_typeexpenses);
            Controls.Add(btn_back);
            Controls.Add(btn_saveexpense);
            Controls.Add(txt_amountexpense);
            Controls.Add(txt_descriptionexpense);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddExpenses";
            Text = "AddExpenses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_descriptionexpense;
        private TextBox txt_amountexpense;
        private Button btn_saveexpense;
        private Button btn_back;
        private ComboBox combobox_typeexpenses;
        private DateTimePicker datetime_expense;
        private Label label4;
        private Label label5;
        private TextBox txt_sellectedproperty;
    }
}