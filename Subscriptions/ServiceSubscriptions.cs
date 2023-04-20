using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using DataBase.Db.DbUsers.Context;
using DataBase.Db.DbUsers.Models;

namespace Subscriptions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceSubscriptions : IServiceSubscriptions
    {
        public void DeleteSubscription(int subscriptionId)
        {
            using (var db = new CtxUsers())
            {
                var sub = db.Subscriptions.Single(s => s.SubscriptionId == subscriptionId);
                db.Subscriptions.Remove(sub);
                db.SaveChanges();
            }
        }

        public bool AddSubscription(bool newS, bool retS, int userId, string genre)
        {
            using (var db = new CtxUsers())
            {
                if (newS == retS) return false;

                db.Subscriptions.Add(new Subscription()
                {
                    Genre = genre,
                    UserId = userId,
                    IsNew = newS,
                    IsReturned = retS,
                });
                db.SaveChanges();
                return true;
            }
        }

        public List<Subscription> GetUserSubscriptions(int userId)
        {
            using (var db = new CtxUsers())
            {
                return db.Subscriptions.ToList();
            }
        }
    }
}
