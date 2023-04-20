using System.Collections.Generic;
using System.ServiceModel;
using DataBase.Db.DbCurrencies.Models;

namespace CurrencyCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceCurrencyCalculator
    {
        [OperationContract]
        List<string> GetCurrencyCodes();

        [OperationContract]
        Currency GetCurrencyByCode(string currencyCode);

        [OperationContract]
        List<Currency> GetCurrencies();

        [OperationContract]
        float CalculateCurrencyValue(float value, string fromCode, string toCode);

        [OperationContract]
        List<float> CalculateCurrenciesValues(List<float> values, string fromCode, string toCode);
    }
}
