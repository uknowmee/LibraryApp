using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataBase.Db.DbBooks.Models;
using Newtonsoft.Json;

namespace DataBase.Db.DbBooks.Context
{
    public partial class CtxBooks
    {
        public void AddBook(UsableBook book)
        {
            Book newBook = book.NewBook();

            Books.Add(new Book()
            {
                Title = newBook.Title,
                Series = newBook.Series,
                Author = newBook.Author,
                Rating = newBook.Rating,
                Description = newBook.Description,
                Language = newBook.Language,
                Genres = newBook.Genres,
                Characters = newBook.Characters,
                BookFormat = newBook.BookFormat,
                Pages = newBook.Pages,
                Publisher = newBook.Publisher,
                NumOfRatings = newBook.NumOfRatings,
                Setting = newBook.Setting,
                CoverImg = newBook.CoverImg,
                Price = newBook.Price
            });

            SaveChanges();
        }

        public UsableBook GetUsableBookFromId(int bookId)
        {
            return UsableBook.NewUsableBook(Books.Single(b => b.BookId == bookId));
        }

        public bool AddAuthor(string author)
        {
            if (Authors.Select(a => a.AuthorName).Contains(author)) return false;

            Authors.Add(new Author()
            {
                AuthorName = author
            });

            SaveChanges();

            return true;
        }

        public bool AddGenre(string genre)
        {
            if (Genres.Select(g => g.Name).Contains(genre)) return false;

            Genres.Add(new Genre()
            {
                Name = genre
            });

            SaveChanges();

            return true;
        }

        public bool AddLanguage(string language)
        {
            if (Languages.Select(l => l.Name).Contains(language)) return false;

            Languages.Add(new Language()
            {
                Name = language
            });

            SaveChanges();

            return true;
        }

        public bool AddSetting(string setting)
        {
            if (Settings.Select(s => s.Name).Contains(setting)) return false;

            Settings.Add(new Setting()
            {
                Name = setting
            });

            SaveChanges();

            return true;
        }

        public bool AddAuthors(List<string> authors)
        {
            if (authors.Any(author => Authors.Select(a => a.AuthorName).ToList().Contains(author))) return false;


            foreach (string author in authors)
            {
                Authors.Add(new Author()
                {
                    AuthorName = author
                });
            }

            SaveChanges();

            return true;
        }

        public bool AddGenres(List<string> genres)
        {
            if (genres.Any(genre => Genres.Select(g => g.Name).ToList().Contains(genre))) return false;

            foreach (string genre in genres)
            {
                Genres.Add(new Genre()
                {
                    Name = genre
                });
            }

            SaveChanges();

            return true;
        }

        public bool AddLanguages(List<string> languages)
        {
            if (languages.Any(language => Languages.Select(l => l.Name).ToList().Contains(language))) return false;

            foreach (string language in languages)
            {
                Languages.Add(new Language()
                {
                    Name = language
                });
            }

            SaveChanges();

            return true;
        }

        public bool AddSettings(List<string> settings)
        {
            if (settings.Any(setting => Settings.Select(s => s.Name).ToList().Contains(setting))) return false;

            foreach (string setting in settings)
            {
                Settings.Add(new Setting()
                {
                    Name = setting
                });
            }

            SaveChanges();

            return true;
        }

        public void AddUsableBooks(Dictionary<int, UsableBook> books)
        {
            int i = 0;

            foreach (var book in books.Values.Select(uBook => uBook.NewBook()))
            {
                Books.Add(new Book()
                {
                    Title = book.Title,
                    Series = book.Series,
                    Author = book.Author,
                    Rating = book.Rating,
                    Description = book.Description,
                    Language = book.Language,
                    Genres = book.Genres,
                    Characters = book.Characters,
                    BookFormat = book.BookFormat,
                    Pages = book.Pages,
                    Publisher = book.Publisher,
                    NumOfRatings = book.NumOfRatings,
                    Setting = book.Setting,
                    CoverImg = book.CoverImg,
                    Price = book.Price
                });

                i += 1;
                StreamWriter streamWriter = new StreamWriter("sth.txt");
                streamWriter.Write("Added: " + i);
                streamWriter.Close();
            }

            SaveChanges();
        }

        public void AddUsableBook(UsableBook uBook)
        {
            AddAuthor(uBook.Author);
            AddGenres(uBook.Genres);
            AddLanguage(uBook.Language);
            AddSettings(uBook.Setting);

            Book book = uBook.NewBook();

            Books.Add(new Book()
            {
                Title = book.Title,
                Series = book.Series,
                Author = book.Author,
                Rating = book.Rating,
                Description = book.Description,
                Language = book.Language,
                Genres = book.Genres,
                Characters = book.Characters,
                BookFormat = book.BookFormat,
                Pages = book.Pages,
                Publisher = book.Publisher,
                NumOfRatings = book.NumOfRatings,
                Setting = book.Setting,
                CoverImg = book.CoverImg,
                Price = book.Price
            });

            SaveChanges();
        }

        public List<string> GetLanguages()
        {
            return Languages.Select(l=>l.Name).ToList();
        }

        public List<string> GetGenresByFirstLetter(string firstLetter, string lower)
        {
            var strings = Genres.Select(g=>g.Name);

            return strings.Where(s => s.StartsWith(firstLetter) || s.StartsWith(lower)).ToList();
        }

        public bool IsBookBorrowed(int bookId)
        {
            return Rents.Any(r => r.BookId == bookId);
        }

        public void AddNewRent(int bookId)
        {
            Rents.Add(new Rent()
            {
                BookId = bookId,
                From = DateTime.Now
            });

            SaveChanges();
        }

        public bool IsBookRemoved(int bookId)
        {
            return Deleted.Any(d => d.BookId == bookId);
        }

        public void RemoveFromRents(int bookId)
        {
            Rent rent = Rents.Single(r => r.BookId == bookId);
            Rents.Remove(rent);
            SaveChanges();
        }
    }
}