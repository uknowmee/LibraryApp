using System.Data.Entity;
using DataBase.Db.DbBooks.Models;

namespace DataBase.Db.DbBooks.Context
{
    public partial class CtxBooks : DbContext
    {
        public CtxBooks() : base("CnStrBooks")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Setting> Settings { get; set; }

        public DbSet<Removed> Deleted { get; set; }
    }
}