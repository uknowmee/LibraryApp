using System.Collections.Generic;
using DataBase.Db.DbBooks.Models;
using Newtonsoft.Json;

namespace DataBase.Db.DbBooks
{
    public class UsableBook
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Author { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Characters { get; set; }
        public string BookFormat { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public int NumOfRatings { get; set; }
        public List<string> Setting { get; set; }
        public string CoverImg { get; set; }
        public float Price { get; set; }

        public Book NewBook()
        {
            return new Book()
            {
                Title = Title,
                Series = Series,
                Author = Author,
                Rating = Rating,
                Description = Description,
                Language = Language,
                Genres = JsonConvert.SerializeObject(Genres),
                Characters = JsonConvert.SerializeObject(Characters),
                BookFormat = BookFormat,
                Pages = Pages,
                Publisher = Publisher,
                NumOfRatings = NumOfRatings,
                Setting = JsonConvert.SerializeObject(Setting),
                CoverImg = CoverImg,
                Price = Price
            };
        }

        public Book NewBookWithId()
        {
            return new Book()
            {
                BookId = BookId,
                Title = Title,
                Series = Series,
                Author = Author,
                Rating = Rating,
                Description = Description,
                Language = Language,
                Genres = JsonConvert.SerializeObject(Genres),
                Characters = JsonConvert.SerializeObject(Characters),
                BookFormat = BookFormat,
                Pages = Pages,
                Publisher = Publisher,
                NumOfRatings = NumOfRatings,
                Setting = JsonConvert.SerializeObject(Setting),
                CoverImg = CoverImg,
                Price = Price
            };
        }

        public static UsableBook NewUsableBook(Book book)
        {

            return new UsableBook()
            {
                BookId = book.BookId,
                Title = book.Title,
                Series = book.Series,
                Author = book.Author,
                Rating = book.Rating,
                Description = book.Description,
                Language = book.Language,
                Genres = JsonConvert.DeserializeObject<List<string>>(book.Genres),
                Characters = JsonConvert.DeserializeObject<List<string>>(book.Characters),
                BookFormat = book.BookFormat,
                Pages = book.Pages,
                Publisher = book.Publisher,
                NumOfRatings = book.NumOfRatings,
                Setting = JsonConvert.DeserializeObject<List<string>>(book.Setting),
                CoverImg = book.CoverImg,
                Price = book.Price
            };
        }
    }
}