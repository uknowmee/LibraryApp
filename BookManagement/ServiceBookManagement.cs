using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataBase.Db.DbBooks.Context;
using DataBase.Db.DbBooks.Models;

namespace BookManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceBookManagement : IServiceBookManagement
    {
        public bool IsBookDeleted(int bookId)
        {
            using (var db = new CtxBooks())
            {
                return db.Deleted.Any(d => d.BookId == bookId);
            }
        }

        public bool DeleteBook(int bookId)
        {
            using (var db = new CtxBooks())
            {
                if (db.Rents.Any(r=>r.BookId == bookId)) return false;

                db.Deleted.Add(new Removed()
                {
                    BookId = bookId
                });
                db.SaveChanges();
                return true;
            }
        }

        public bool RestoreBook(int bookId)
        {
            using (var db = new CtxBooks())
            {
                var removed = db.Deleted.Single(d => d.BookId == bookId);

                db.Deleted.Remove(removed);

                db.SaveChanges();
                return true;
            }
        }

        public void AddNewBook(string textBoxRating, string textBoxLanguage, string textBoxRates, string textBoxAuthor,
            string textBoxPrice, string textBoxCharacters, string textBoxGenres, string textBoxSetting,
            string textBoxDescription, string textBoxTitle, string textBoxSeries, string textBoxPages, string textBoxFormat,
            string textBoxPublisher, string textBoxLink)
        {
            using (var db = new CtxBooks())
            {
                db.Books.Add(new Book()
                {
                    Title = textBoxTitle,
                    Series = textBoxSeries,
                    Author = textBoxAuthor,
                    Rating = float.Parse(textBoxRating),
                    Description = textBoxDescription,
                    Language = textBoxLanguage,
                    Genres = textBoxGenres,
                    Characters = textBoxCharacters,
                    BookFormat = textBoxFormat,
                    Pages = int.Parse(textBoxPages),
                    Publisher = textBoxPublisher,
                    NumOfRatings = int.Parse(textBoxRating),
                    Setting = textBoxSetting,
                    CoverImg = textBoxLink,
                    Price = int.Parse(textBoxPrice)
                });

                db.SaveChanges();
            }
        }

        public void EditBook(int bookId, string textBoxRating, string textBoxLanguage, string textBoxRates, string textBoxAuthor,
            string textBoxPrice, string textBoxCharacters, string textBoxGenres, string textBoxSetting,
            string textBoxDescription, string textBoxTitle, string textBoxSeries, string textBoxPages, string textBoxFormat,
            string textBoxPublisher, string textBoxLink)
        {
            using (var db = new CtxBooks())
            {
                var book = db.Books.Single(b => b.BookId == bookId);

                book.Title = textBoxTitle;
                book.Series = textBoxSeries;
                book.Author = textBoxAuthor;
                book.Rating = float.Parse(textBoxRating);
                book.Description = textBoxDescription;
                book.Language = textBoxLanguage;
                book.Genres = textBoxGenres;
                book.Characters = textBoxCharacters;
                book.BookFormat = textBoxFormat;
                book.Pages = int.Parse(textBoxPages);
                book.Publisher = textBoxPublisher;
                book.NumOfRatings = int.Parse(textBoxRating);
                book.Setting = textBoxSetting;
                book.CoverImg = textBoxLink;
                book.Price = int.Parse(textBoxPrice);

                db.SaveChanges();
            }
        }
    }
}
