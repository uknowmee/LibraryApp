using System;

namespace DataBase.Db.DbUsers.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool IsNew { get; set; }
        public bool IsReturned { get; set; }
        public string Genre { get; set; }
    }
}