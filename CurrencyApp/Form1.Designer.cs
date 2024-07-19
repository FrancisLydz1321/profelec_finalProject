namespace CurrencyApp
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
            cmbFromCurrency = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbToCurrency = new ComboBox();
            txtFromCurrencyAmount = new TextBox();
            txtToCurrencyAmount = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbFromCurrency
            // 
            cmbFromCurrency.FormattingEnabled = true;
            cmbFromCurrency.Location = new Point(301, 119);
            cmbFromCurrency.Name = "cmbFromCurrency";
            cmbFromCurrency.Size = new Size(414, 28);
            cmbFromCurrency.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 81);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "From Currency ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 243);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "To Currency";
            // 
            // cmbToCurrency
            // 
            cmbToCurrency.FormattingEnabled = true;
            cmbToCurrency.Location = new Point(301, 278);
            cmbToCurrency.Name = "cmbToCurrency";
            cmbToCurrency.Size = new Size(414, 28);
            cmbToCurrency.TabIndex = 3;
            // 
            // txtFromCurrencyAmount
            // 
            txtFromCurrencyAmount.Location = new Point(90, 119);
            txtFromCurrencyAmount.Name = "txtFromCurrencyAmount";
            txtFromCurrencyAmount.Size = new Size(125, 27);
            txtFromCurrencyAmount.TabIndex = 4;
            // 
            // txtToCurrencyAmount
            // 
            txtToCurrencyAmount.Location = new Point(90, 279);
            txtToCurrencyAmount.Name = "txtToCurrencyAmount";
            txtToCurrencyAmount.Size = new Size(125, 27);
            txtToCurrencyAmount.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(348, 369);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtToCurrencyAmount);
            Controls.Add(txtFromCurrencyAmount);
            Controls.Add(cmbToCurrency);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbFromCurrency);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFromCurrency;
        private Label label1;
        private Label label2;
        private ComboBox cmbToCurrency;
        private TextBox txtFromCurrencyAmount;
        private TextBox txtToCurrencyAmount;
        private Button button1;
    }
}
