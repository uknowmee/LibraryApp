using System.Collections.Generic;
using System.ServiceModel;
using DataBase.Db.DbUsers.Models;

namespace Login
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceLogin
    {
        [OperationContract]
        User Login(string userName, string userPassword);

        [OperationContract]
        bool IsUserAdmin(int userId);

        [OperationContract]
        List<Card> GetUserCards(int userId);

        [OperationContract]
        List<History> GetUserHistory(int userId);

        [OperationContract]
        Card GetCardById(int cardId);

        [OperationContract]
        List<User> GetUsersNonAdmin();
    }
}
