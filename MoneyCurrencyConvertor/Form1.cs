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
            List<Currency> Currencies = CreateCurrencyList();

            CurrencyTypeInBox = FillCurrencyTypeInBox(CurrencyTypeInBox, Currencies);
            CurrencyTypeOutBox = FillCurrencyTypeInBox(CurrencyTypeOutBox, Currencies);
        }

        public List<Currency> CreateCurrencyList()
        {
            string[] CurrencyNames = { "EUR", "USD", "UAH" };
            double[] CurrencyCourcesInDollars = { 0.8378, 1, 28.0775 };
            List<Currency> Currencies = new List<Currency>();
            Currencies = AddToListOfCurrencies(Currencies, CurrencyNames, CurrencyCourcesInDollars);

            return Currencies;
        }

        public List<Currency> AddToListOfCurrencies(List<Currency> currencies, string[] currencyNames, double[] currencyCourcesInDollars)
        {
            for (int i = 0; i < currencyNames.Length; i++)
            {
                currencies.Add(new Currency(currencyNames[i], currencyCourcesInDollars[i]));
            }
            return currencies;
        }

        public ComboBox FillCurrencyTypeInBox(ComboBox comboBox, List<Currency> currenciesList)
        {
            if (currenciesList != null)
            {
                for (int i = 0; i < currenciesList.Count; i++)
                {
                    comboBox.Items.Add(currenciesList[i].NameOfCurrency);
                }
            }

            return comboBox;
        }

        public int FindPlaceByNameInCurrencyList(List<Currency> currenciesList, string searchingName)
        {
            if(currenciesList != null)
            {
                for(int i=0; i<currenciesList.Count; i++)
                {
                    if (currenciesList[i].NameOfCurrency == searchingName)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            (CurrencyTypeInBox.Text, CurrencyTypeOutBox.Text) = (CurrencyTypeOutBox.Text, CurrencyTypeInBox.Text);
        }

        private void NumericAmountIn_ValueChanged(object sender, EventArgs e)
        {
            NumericAmountOut.Maximum = int.MaxValue;
            NumericAmountOut.Minimum = int.MinValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Currency> Currencies = CreateCurrencyList();
            double FactorOut = Currencies[FindPlaceByNameInCurrencyList(Currencies, CurrencyTypeOutBox.Text)].AmountCourceInDollars;
            double FactorIn = Currencies[FindPlaceByNameInCurrencyList(Currencies, CurrencyTypeInBox.Text)].AmountCourceInDollars;
            double Factor = FactorOut / FactorIn;
            OutAmountTextBox.Text = Convert.ToString(Convert.ToDouble(NumericAmountOut.Value)/Factor);

        }
    }

    public class Currency
    {
        public double AmountCourceInDollars;
        public string NameOfCurrency;

        public Currency(string nameOfCurrency, double amountCource)
        {
            this.AmountCourceInDollars = amountCource;
            this.NameOfCurrency = nameOfCurrency;
        }
    }
}
