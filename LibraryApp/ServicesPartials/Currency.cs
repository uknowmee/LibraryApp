namespace LibraryApp.ServiceCurrencyCalculator
{
    public partial class Currency
    {
        public override string ToString()
        {
            return Code + " - " + Name;
        }

        public static bool IsPln(Currency currency)
        {
            return currency.Code == "PLN";
        }

        public static bool IsEur(Currency currency)
        {
            return currency.Code == "EUR";
        }
    }
}