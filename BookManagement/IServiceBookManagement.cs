using System.ServiceModel;

namespace BookManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBookManagement
    {
        [OperationContract]
        bool IsBookDeleted(int bookId);

        [OperationContract]
        bool DeleteBook(int bookId);

        [OperationContract]
        bool RestoreBook(int bookId);

        [OperationContract]
        void AddNewBook(string textBoxRating, string textBoxLanguage, string textBoxRates, string textBoxAuthor, string
            textBoxPrice, string textBoxCharacters, string textBoxGenres, string textBoxSetting, string textBoxDescription,
        string textBoxTitle, string textBoxSeries, string textBoxPages, string textBoxFormat, string textBoxPublisher, string textBoxLink);

        [OperationContract]
        void EditBook(int bookId, string textBoxRating, string textBoxLanguage, string textBoxRates, string textBoxAuthor, string
                textBoxPrice, string textBoxCharacters, string textBoxGenres, string textBoxSetting, string textBoxDescription,
            string textBoxTitle, string textBoxSeries, string textBoxPages, string textBoxFormat, string textBoxPublisher, string textBoxLink);
    }
}
