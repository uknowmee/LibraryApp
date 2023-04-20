using System.Collections.Generic;
using System.ServiceModel;
using DataBase.Db.DbBooks;
using DataBase.Db.DbUsers.Models;

namespace Notifications
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceNotifications
    {
        [OperationContract]
        void SendNotificationsReturned(int bookId, int userId);

        [OperationContract]
        void SendNotificationsNew(int bookId);

        [OperationContract]
        List<Notification> GetUserNotifications(int userId);

        [OperationContract]
        void RemoveNotification(int notificationId);

        [OperationContract]
        List<UsableBook> TimeIsEnding(int userId);
    }
}
