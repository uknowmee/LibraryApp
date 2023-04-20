namespace DataBase.Db.DbBooks.Models
{
    public class Removed
    {
        public int RemovedId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}