using System;

namespace DataBase.Db.DbBooks.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime From { get; set; }
    }
}