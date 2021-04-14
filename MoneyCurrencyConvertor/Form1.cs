using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCurrencyConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PreparationOfComponents();
        }

        private void PreparationOfComponents()
        {
            List<Currency> Currencies = Currency.CreateStockCurrencyList();
            CurrencyTypeInBox = Currency.FillCurrencyTypeInBox(CurrencyTypeInBox, Currencies);
            CurrencyTypeOutBox = Currency.FillCurrencyTypeInBox(CurrencyTypeOutBox, Currencies);
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            (CurrencyTypeInBox.Text, CurrencyTypeOutBox.Text) = (CurrencyTypeOutBox.Text, CurrencyTypeInBox.Text);
        }

        private void NumericAmountIn_ValueChanged(object sender, EventArgs e)
        {
            NumericAmountIn.Maximum = int.MaxValue;
            NumericAmountIn.Minimum = int.MinValue;
            NumericAmountIn.DecimalPlaces = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutAmountTextBox.Text = Currency.ConvertCurrencies(ref CurrencyTypeOutBox, ref CurrencyTypeInBox, ref NumericAmountIn);
        }

    }

    
}
