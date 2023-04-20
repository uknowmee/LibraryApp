using System.Collections.Generic;
using System.ServiceModel;
using DataBase.Db.DbUsers.Models;

namespace Subscriptions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceSubscriptions
    {
        [OperationContract]
        void DeleteSubscription(int subscriptionId);

        [OperationContract]
        bool AddSubscription(bool newS, bool retS, int userId, string genre);

        [OperationContract]
        List<Subscription> GetUserSubscriptions(int userId);
    }
}
