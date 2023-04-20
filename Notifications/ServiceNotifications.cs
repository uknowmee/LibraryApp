using System;
using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbBooks;
using DataBase.Db.DbBooks.Context;
using DataBase.Db.DbUsers.Context;
using DataBase.Db.DbUsers.Models;

namespace Notifications
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceNotifications : IServiceNotifications
    {
        public void SendNotificationsReturned(int bookId, int userId)
        {
            UsableBook usableBook;

            using (var db = new CtxBooks())
            {
                usableBook = db.GetUsableBookFromId(bookId);
            }

            using (var db = new CtxUsers())
            {
                var subscriptions = db.Subscriptions.Where(s => s.IsReturned);
                subscriptions = subscriptions.Where(s => usableBook.Genres.Contains(s.Genre));

                foreach (Subscription subscription in subscriptions)
                {
                    if (subscription.UserId == userId) continue;

                    db.Notifications.Add(new Notification()
                    {
                        Appear = DateTime.Now,
                        BookId = bookId,
                        UserId = subscription.UserId,
                        ToReturn = false
                    });
                }
                db.SaveChanges();
            }
        }
        public void SendNotificationsNew(int bookId)
        {
            UsableBook usableBook;

            using (var db = new CtxBooks())
            {
                usableBook = db.GetUsableBookFromId(bookId);
            }

            using (var db = new CtxUsers())
            {
                var subscriptions = db.Subscriptions.Where(s => s.IsNew);
                subscriptions = subscriptions.Where(s => usableBook.Genres.Contains(s.Genre));

                foreach (Subscription subscription in subscriptions)
                {
                    db.Notifications.Add(new Notification()
                    {
                        Appear = DateTime.Now,
                        BookId = bookId,
                        UserId = subscription.UserId,
                        ToReturn = false
                    });

                    db.SaveChanges();
                }
            }
        }

        public List<Notification> GetUserNotifications(int userId)
        {
            using (var db = new CtxUsers())
            {
                return db.Notifications.Where(n => n.UserId == userId).ToList();
            }
        }

        public void RemoveNotification(int notificationId)
        {
            using (var db = new CtxUsers())
            {
                var notification = db.Notifications.Single(n => n.NotificationId == notificationId);
                db.Notifications.Remove(notification);
                db.SaveChanges();
            }
        }

        public List<UsableBook> TimeIsEnding(int userId)
        {
            List<UsableBook> usableBookList = new List<UsableBook>();

            using (var dbBooks = new CtxBooks())
            {
                using (var db = new CtxUsers())
                {
                    var rents = db.GetUserRents(userId);
                    foreach (var rent in rents.Where(rent => DateTime.Now > rent.To.AddDays(-5)))
                    {
                        usableBookList.Add(dbBooks.GetUsableBookFromId(rent.BookId));
                        db.Notifications.Add(new Notification()
                        {
                            Appear = DateTime.Now,
                            BookId = rent.BookId,
                            ToReturn = true,
                            UserId = userId
                        });
                    }

                    db.SaveChanges();

                    return usableBookList;
                }
            }
        }
    }
}
