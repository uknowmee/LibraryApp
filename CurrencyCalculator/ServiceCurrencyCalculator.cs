using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbCurrencies.Context;
using DataBase.Db.DbCurrencies.Models;

namespace CurrencyCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceCurrencyCalculator : IServiceCurrencyCalculator
    {
        public List<string> GetCurrencyCodes()
        {
            CurrencyFetcher.FetchCurrencies();

            using (var db = new CtxCurrencies())
            {
                return db.GetCurrencyCodes();
            }
        }

        public Currency GetCurrencyByCode(string currencyCode)
        {
            CurrencyFetcher.FetchCurrencies();

            using (var db = new CtxCurrencies())
            {
                return db.GetCurrencyByCode(currencyCode);
            }
        }

        public List<Currency> GetCurrencies()
        {
            CurrencyFetcher.FetchCurrencies();

            using (var db = new CtxCurrencies())
            {
                return db.GetCurrencies();
            }
        }

        public float CalculateCurrencyValue(float value, string fromCode, string toCode)
        {
            CurrencyFetcher.FetchCurrencies();

            using (var db = new CtxCurrencies())
            {
                Currency oldCurrency = db.GetCurrencyByCode(fromCode);
                Currency newCurrency = db.GetCurrencyByCode(toCode);

                float newValue = value * oldCurrency.Value / newCurrency.Value;

                return float.Parse(newValue.ToString("n2"));
            }
        }

        public List<float> CalculateCurrenciesValues(List<float> values, string fromCode, string toCode)
        {
            using (var db = new CtxCurrencies())
            {
                Currency oldCurrency = db.GetCurrencyByCode(fromCode);
                Currency newCurrency = db.GetCurrencyByCode(toCode);

                return values
                    .Select(value => value * oldCurrency.Value / newCurrency.Value)
                    .Select(newValue => float.Parse(newValue.ToString("n2")))
                    .ToList();
            }
        }
    }
}
