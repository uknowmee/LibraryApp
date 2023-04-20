using System;

namespace DataBase.Db.DbUsers.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Appear { get; set; }
        public bool ToReturn { get; set; }
    }
}