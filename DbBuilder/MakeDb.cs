using System;
using System.Collections.Generic;
using System.IO;
using DataBase.Db.DbBooks;
using DataBase.Db.DbCurrencies.Context;
using Newtonsoft.Json;
using CtxBooks = DataBase.Db.DbBooks.Context.CtxBooks;
using CtxUsers = DataBase.Db.DbUsers.Context.CtxUsers;

namespace DbBuilder
{
    public static class MakeDb
    {
        private const string AdminName = "Admin";
        private const string AdminPass = "ImAdmin";

        public static void ShouldMakeDb()
        {
            bool shouldMakeBooksDb;
            bool shouldMakeUsersDb;
            bool shouldMakeCurrencyDb;

            using (var db = new CtxBooks())
            {
                shouldMakeBooksDb = !db.Database.Exists();
            }

            using (var db = new CtxUsers())
            {
                shouldMakeUsersDb = !db.Database.Exists();
            }

            using (var db = new CtxCurrencies())
            {
                shouldMakeCurrencyDb = !db.Database.Exists();
            }

            MakeStartBookDb(shouldMakeBooksDb);
            MakeStartUserDb(shouldMakeUsersDb);
            MakeStartCurrencyDb(shouldMakeCurrencyDb);
        }

        private static void MakeStartCurrencyDb(bool shouldMakeDb)
        {
            using (var db = new CtxCurrencies())
            {
                if (!shouldMakeDb)
                {
                    Console.Out.WriteLine("CurrencyDb already created");
                    return;
                }

                Console.Out.WriteLine("Creating CurrencyDb");

                db.Database.CreateIfNotExists();

                Console.Out.WriteLine("Created CurrencyDb");
            }
        }

        private static void MakeStartUserDb(bool shouldMakeDb)
        {
            using (var db = new CtxUsers())
            {
                if (!shouldMakeDb)
                {
                    Console.Out.WriteLine("UsersDb already created");
                    return;
                }

                Console.Out.WriteLine("Creating UsersDb");

                db.Database.CreateIfNotExists();

                AddUsers();

                Console.Out.WriteLine("Created UsersDb");
            }
        }

        private static void AddUsers()
        {
            using (var db = new CtxUsers())
            {
                db.AddAdmin(AdminName, new DataBase.Utils.PassHash(AdminPass));
            }
        }

        private static void MakeStartBookDb(bool shouldMakeDb)
        {
            using (var db = new CtxBooks())
            {
                if (!shouldMakeDb)
                {
                    Console.Out.WriteLine("BooksDb already created");
                    return;
                }

                Console.Out.WriteLine("Creating BooksDb");

                db.Database.CreateIfNotExists();

                AddBooks();

                Console.Out.WriteLine("Created BooksDb");
            }
        }

        private static void AddBooks()
        {
            using (var db = new CtxBooks())
            {
                StreamReader stAuthors = new StreamReader(@"../../ScrappedBooksData/authors.json");
                StreamReader stGenres = new StreamReader(@"../../ScrappedBooksData/genres.json");
                StreamReader stLanguages = new StreamReader(@"../../ScrappedBooksData/languages.json");
                StreamReader stSettings = new StreamReader(@"../../ScrappedBooksData/setting.json");
                StreamReader stBooks = new StreamReader(@"../../ScrappedBooksData/books.json");

                string jsonAuthors = stAuthors.ReadToEnd();
                string jsonGenres = stGenres.ReadToEnd();
                string jsonLanguages = stLanguages.ReadToEnd();
                string jsonSettings = stSettings.ReadToEnd();
                string jsonBooks = stBooks.ReadToEnd();

                List<string> authors = JsonConvert.DeserializeObject<List<string>>(jsonAuthors);
                List<string> genres = JsonConvert.DeserializeObject<List<string>>(jsonGenres);
                List<string> languages = JsonConvert.DeserializeObject<List<string>>(jsonLanguages);
                List<string> settings = JsonConvert.DeserializeObject<List<string>>(jsonSettings);
                Dictionary<int, UsableBook> books = JsonConvert.DeserializeObject<Dictionary<int, UsableBook>>(jsonBooks);

                Console.Out.WriteLine("Starting Inserts! " + DateTime.Now);
                db.AddAuthors(authors);
                Console.Out.WriteLine("Authors Added! " + DateTime.Now);
                db.AddGenres(genres);
                Console.Out.WriteLine("Genres Added! " + DateTime.Now);
                db.AddLanguages(languages);
                Console.Out.WriteLine("Languages Added! " + DateTime.Now);
                db.AddSettings(settings);
                Console.Out.WriteLine("Settings Added! " + DateTime.Now);
                db.AddUsableBooks(books);
                Console.Out.WriteLine("Books Added! " + DateTime.Now);
            }
        }
    }
}