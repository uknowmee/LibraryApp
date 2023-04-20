using System;
using System.Collections.Generic;
using System.ServiceModel;
using DataBase.Db.DbBooks;

namespace BooksView
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBooksView
    {
        [OperationContract]
        List<UsableBook> GetBooksFiltered(string titleAuthor, int maxPrice, int minPrice,
            int maxPages, int minPages, List<string> genres, string language);

        [OperationContract]
        List<String> GetLanguages();

        [OperationContract]
        List<string> GetGenresByFirstLetter(string firstLetter);

        [OperationContract]
        List<string> GetGenres();

        [OperationContract]
        UsableBook GetUsableBookById(int bookId);
    }
}
