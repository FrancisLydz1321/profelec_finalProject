using System;
using System.Windows.Forms;
using CurrencyConverter = CurrencyApp.CurrencyConverter;

namespace CurrencyApp
{
    public partial class Form1 : Form
    {
        CurrencyConverter currencyConverter;
        public Form1()
        {
            InitializeComponent();
            currencyConverter = new CurrencyConverter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> symbolData = currencyConverter.GetSymbols();
            cmbFromCurrency.Items.Clear();
            cmbToCurrency.Items.Clear();

            cmbFromCurrency.DataSource = new BindingSource(symbolData, null);
            cmbFromCurrency.DisplayMember = "Value";
            cmbFromCurrency.ValueMember = "Key";

            cmbToCurrency.DataSource = new BindingSource(symbolData, null);
            cmbToCurrency.DisplayMember = "Value";
            cmbToCurrency.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromCurrency = ((KeyValuePair<string, string>)cmbFromCurrency.SelectedItem).Key;
            string toCurrency = ((KeyValuePair<string, string>)cmbToCurrency.SelectedItem).Key;

            double currencyAmount = double.Parse(txtFromCurrencyAmount.Text);
            double finalValue = currencyConverter.Convert(fromCurrency, toCurrency, currencyAmount);

            txtToCurrencyAmount.Text = finalValue.ToString();
        }
    }
}
