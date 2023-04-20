using System;

namespace DataBase.Db.DbUsers.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int BookId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Prolonged { get; set; }
    }
}