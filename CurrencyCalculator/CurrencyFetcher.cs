using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
using DataBase.Db.DbCurrencies.Context;
using DataBase.Db.DbCurrencies.Models;
using Newtonsoft.Json;

namespace CurrencyCalculator
{
    public static class CurrencyFetcher
    {
        private class Table
        {
            public string table { get; set; }
            public string no { get; set; }
            public string effectiveDate { get; set; }
            public List<Rate> rates { get; set; }
        }

        private class Rate
        {
            public string currency { get; set; }
            public string code { get; set; }

            public float mid { get; set; }
        }

        public static void FetchCurrencies()
        {
            using (var db = new CtxCurrencies())
            {
                if (!db.ShouldUpdate()) return;

                string html = "";
                const string url = @"https://api.nbp.pl/api/exchangerates/tables/a/?format=json";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream != null)
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                html = reader.ReadToEnd();
                            }
                    }
                }

                List<Table> tables = JsonConvert.DeserializeObject<List<Table>>(html);


                if (tables == null) return;

                List<Currency> currencies = tables[0].rates.Select(rate => new Currency() { Code = rate.code, Name = rate.currency, Value = rate.mid }).ToList();

                db.RefreshCurrencies(currencies);
            }
        }
    }
}