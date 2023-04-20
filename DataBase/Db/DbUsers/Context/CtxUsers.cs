using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using DataBase.Db.DbUsers.Models;

namespace DataBase.Db.DbUsers.Context
{
    public partial class CtxUsers : DbContext
    {
        public CtxUsers() : base("CnStrUsers") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}