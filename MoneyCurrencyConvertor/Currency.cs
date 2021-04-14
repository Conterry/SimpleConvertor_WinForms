using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyCurrencyConvertor
{
    public class Currency
    {
        public double amountCourceInDollars;
        public string nameOfCurrency;

        public Currency(string nameOfCurrency, double amountCource)
        {
            this.amountCourceInDollars = amountCource;
            this.nameOfCurrency = nameOfCurrency;
        }

        static public List<Currency> CreateStockCurrencyList()
        {
            string[] CurrencyNames = { "EUR", "USD", "UAH" };
            double[] CurrencyCourcesInDollars = { 0.8378, 1, 28.0775 };
            List<Currency> Currencies = new List<Currency>();
            Currencies = AddToListOfCurrencies(Currencies, CurrencyNames, CurrencyCourcesInDollars);

            return Currencies;
        }

        static private List<Currency> AddToListOfCurrencies(List<Currency> currencies, string[] currencyNames, double[] currencyCourcesInDollars)
        {
            for (int i = 0; i < currencyNames.Length; i++)
            {
                currencies.Add(new Currency(currencyNames[i], currencyCourcesInDollars[i]));
            }
            return currencies;
        }

        static public System.Windows.Forms.ComboBox FillCurrencyTypeInBox(System.Windows.Forms.ComboBox comboBox, List<Currency> currenciesList)
        {
            if (currenciesList != null)
            {
                for (int i = 0; i < currenciesList.Count; i++)
                {
                    comboBox.Items.Add(currenciesList[i].nameOfCurrency);
                }
            }

            return comboBox;
        }


        private static int FindPlaceByNameInCurrencyList(List<Currency> currenciesList, string searchingName)
        {
            if (currenciesList != null)
            {
                for (int i = 0; i < currenciesList.Count; i++)
                {
                    if (currenciesList[i].nameOfCurrency == searchingName)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }


        public static string ConvertCurrencies(ref System.Windows.Forms.ComboBox currencyType1, ref System.Windows.Forms.ComboBox currencyType2, ref System.Windows.Forms.NumericUpDown numericAmountIn)
        {
            List<Currency> Currencies = CreateStockCurrencyList();
            double FactorOut = Currencies[FindPlaceByNameInCurrencyList(Currencies, currencyType1.Text)].amountCourceInDollars;
            double FactorIn = Currencies[FindPlaceByNameInCurrencyList(Currencies, currencyType2.Text)].amountCourceInDollars;
            double Factor = FactorOut / FactorIn;
            double ResultValue = Convert.ToDouble(numericAmountIn.Value) / Factor;
            ResultValue = Math.Round(ResultValue, 2);
            return Convert.ToString(ResultValue);
        }
    }
}
