using System.Collections.Generic;
using System.ServiceModel;

namespace Rent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceRent
    {
        [OperationContract]
        List<DataBase.Db.DbUsers.Models.Rent> GetUserRents(int userId);

        [OperationContract]
        bool AddNewCard(int userId, string ownerName, string ownerSurname);

        [OperationContract]
        bool DeleteCard(int cardId);

        [OperationContract]
        bool BorrowBook(int userId, int cardId, int bookId);

        [OperationContract]
        bool ProlongBook(int userId, int cardId, int bookId);

        [OperationContract]
        bool ReturnBook(int userId, int cardId, int bookId);
    }
}
