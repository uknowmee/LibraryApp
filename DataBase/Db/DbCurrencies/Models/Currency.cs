using System.ComponentModel.DataAnnotations;

namespace DataBase.Db.DbCurrencies.Models
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
    }
}