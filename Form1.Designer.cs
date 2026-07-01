namespace ValueConverter
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
            label1 = new Label();
            label2 = new Label();
            CurrCurrency = new ComboBox();
            ConvCurrency = new ComboBox();
            btnConvert = new Button();
            CurrValue = new TextBox();
            ConvValue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 117);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Текущая валюта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 117);
            label2.Name = "label2";
            label2.Size = new Size(237, 15);
            label2.TabIndex = 1;
            label2.Text = "Валюта в которую хотите конвертировать";
            // 
            // CurrCurrency
            // 
            CurrCurrency.FormattingEnabled = true;
            CurrCurrency.Location = new Point(136, 146);
            CurrCurrency.Name = "CurrCurrency";
            CurrCurrency.Size = new Size(98, 23);
            CurrCurrency.TabIndex = 2;
            // 
            // ConvCurrency
            // 
            ConvCurrency.FormattingEnabled = true;
            ConvCurrency.Location = new Point(457, 146);
            ConvCurrency.Name = "ConvCurrency";
            ConvCurrency.Size = new Size(98, 23);
            ConvCurrency.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(287, 196);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(115, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Конвертировать";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // CurrValue
            // 
            CurrValue.Location = new Point(136, 196);
            CurrValue.Name = "CurrValue";
            CurrValue.Size = new Size(98, 23);
            CurrValue.TabIndex = 5;
            // 
            // ConvValue
            // 
            ConvValue.Location = new Point(457, 196);
            ConvValue.Name = "ConvValue";
            ConvValue.Size = new Size(98, 23);
            ConvValue.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConvValue);
            Controls.Add(CurrValue);
            Controls.Add(btnConvert);
            Controls.Add(ConvCurrency);
            Controls.Add(CurrCurrency);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ValueConverter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CurrCurrency;
        private ComboBox ConvCurrency;
        private Button btnConvert;
        private TextBox CurrValue;
        private TextBox ConvValue;
    }
}
