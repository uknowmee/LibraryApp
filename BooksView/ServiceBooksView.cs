using System;
using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbBooks;
using DataBase.Db.DbBooks.Context;

namespace BooksView
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceBooksView : IServiceBooksView
    {
        public List<UsableBook> GetBooksFiltered(string titleAuthor, int maxPrice, int minPrice, int maxPages, int minPages, List<string> genres, string language)
        {
            using (var db = new CtxBooks())
            {
                var uBooks = db.Books.ToList().Select(UsableBook.NewUsableBook);

                uBooks = uBooks.Where(u => u.Price < maxPrice && u.Price > minPrice);

                uBooks = uBooks.Where(u => u.Pages < maxPages && u.Pages > minPages);

                if (language != "")
                {
                    uBooks = uBooks.Where(u => u.Language == language);
                }

                if (titleAuthor != "")
                {
                    uBooks = uBooks
                        .Where(u => u.Author.Contains(titleAuthor) || u.Title.Contains(titleAuthor));
                }

                if (genres.Count != 0)
                {
                    uBooks = genres.Contains("Empty") ? uBooks.Where(u => genres.Count == 0) : uBooks.Where(u => genres.Any(g => u.Genres.Contains(g)));
                }

                return uBooks.ToList();
            }
        }

        public List<string> GetLanguages()
        {
            using (var db = new CtxBooks())
            {
                return db.GetLanguages();
            }
        }

        public List<string> GetGenresByFirstLetter(string firstLetter)
        {
            using (var db = new CtxBooks())
            {
                return db.GetGenresByFirstLetter(firstLetter, firstLetter.ToLower());
            }
        }

        public List<string> GetGenres()
        {
            using (var db = new CtxBooks())
            {
                return db.Genres.Select(g=>g.Name).ToList();
            }
        }

        public UsableBook GetUsableBookById(int bookId)
        {
            using (var db = new CtxBooks())
            {
                return db.GetUsableBookFromId(bookId);
            }
        }
    }
}
