using System.Data.Entity;
using DataBase.Db.DbCurrencies.Models;

namespace DataBase.Db.DbCurrencies.Context
{
    public partial class CtxCurrencies : DbContext
    {
        public CtxCurrencies() : base("CnStrCurrencies") {}

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Update> Updates { get; set; }
    }
}