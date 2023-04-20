using System;

namespace DataBase.Db.DbUsers.Models
{
    public class History
    {
        public int HistoryId { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int BookId { get; set; }
    }
}