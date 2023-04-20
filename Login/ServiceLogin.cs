using System;
using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbUsers.Context;
using DataBase.Db.DbUsers.Models;

namespace Login
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceLogin : IServiceLogin
    {
        public User Login(string userName, string userPassword)
        {
            using (var db = new CtxUsers())
            {
                if (db.DoesUserExist(userName))
                {
                    return db.DoesUserPassMatch(userName, userPassword) ? db.GetUserByName(userName) : null;
                }

                return null;
            }
        }

        public bool IsUserAdmin(int userId)
        {
            using (var db = new CtxUsers())
            {
                return db.IsUserAdmin(userId);
            }
        }

        public List<Card> GetUserCards(int userId)
        {
            using (var db = new CtxUsers())
            {
                return db.GetUserCards(userId);
            }
        }

        public List<History> GetUserHistory(int userId)
        {
            using (var db = new CtxUsers())
            {
                var cardIds = db.Cards.Where(c => c.UserId == userId).Select(c=>c.CardId).ToList();


                return db.Histories.Where(h => cardIds.Contains(h.CardId)).ToList();
            }
        }

        public Card GetCardById(int cardId)
        {
            using (var db = new CtxUsers())
            {
                return db.Cards.Single(c => c.CardId == cardId);
            }
        }

        public List<User> GetUsersNonAdmin()
        {
            using (var db = new CtxUsers())
            {
                var adminIds = db.Admins.Select(a => a.UserId);

                return db.Users.Where(u => !adminIds.Contains(u.UserId)).ToList();
            }
        }
    }
}
