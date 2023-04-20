namespace DataBase.Db.DbUsers.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
    }
}