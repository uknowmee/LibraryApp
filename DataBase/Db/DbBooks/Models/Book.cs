using System.Collections.Generic;

namespace DataBase.Db.DbBooks.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Author { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string Genres { get; set; }
        public string Characters { get; set; }
        public string BookFormat { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public int NumOfRatings { get; set; }
        public string Setting { get; set; }
        public string CoverImg { get; set; }
        public float Price { get; set; }
    }
}