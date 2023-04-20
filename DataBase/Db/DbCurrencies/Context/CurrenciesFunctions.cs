using System;
using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbCurrencies.Models;

namespace DataBase.Db.DbCurrencies.Context
{
    public partial class CtxCurrencies
    {
        public List<string> GetCurrencyCodes()
        {
            return Currencies.Select(c => c.Code).ToList();
        }

        public Currency GetCurrencyByCode(string currencyCode)
        {
            return Currencies.Single(c => c.Code == currencyCode);
        }

        public List<Currency> GetCurrencies()
        {
            return Currencies.ToList();
        }

        public void RefreshCurrencies(List<Currency> currencies)
        {
            foreach (Currency currency in Currencies)
            {
                Currencies.Remove(currency);
            }

            SaveChanges();

            Currencies.Add(new Currency()
            {
                Code = "PLN",
                Name = "Polski Złoty",
                Value = 1
            });

            foreach (Currency currency in currencies)
            {
                Currencies.Add(new Currency()
                {
                    Code = currency.Code,
                    Name = currency.Name,
                    Value = currency.Value
                });
            }

            SaveChanges();

            AddNewUpdate();
        }

        private void AddNewUpdate()
        {
            Updates.Add(new Update()
            {
                Date = DateTime.Now
            });

            SaveChanges();
        }

        public bool ShouldUpdate()
        {
            if (Updates.ToList().Count == 0) return true;

            DateTime last = Updates.ToList()[Updates.ToList().Count - 1].Date;

            if (DateTime.Now.Year != last.Year ||
                DateTime.Now.DayOfYear != last.DayOfYear ||
                DateTime.Now.Hour != last.Hour
                )
            {
                return true;
            }

            return (DateTime.Now - last).Minutes > 1;
        }
    }
}