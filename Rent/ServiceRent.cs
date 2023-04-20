using System;
using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbBooks.Context;
using DataBase.Db.DbUsers.Context;

namespace Rent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceRent : IServiceRent
    {
        public List<DataBase.Db.DbUsers.Models.Rent> GetUserRents(int userId)
        {
            using (var db = new CtxUsers())
            {
                return db.GetUserRents(userId);
            }
        }

        public bool AddNewCard(int userId, string ownerName, string ownerSurname)
        {
            using (var db = new CtxUsers())
            {
                var userCards = db.GetUserCards(userId);
                if (userCards.Count == 5) return false;

                if (userCards.Any(userCard => userCard.OwnerName == ownerName && userCard.OwnerSurname == ownerSurname))
                {
                    return false;
                }

                db.AddNewUserCard(userId, ownerName, ownerSurname);
                return true;
            }
        }

        public bool DeleteCard(int cardId)
        {
            using (var db = new CtxUsers())
            {
                if (db.GetCardRents(cardId).Count != 0) return false;

                db.DeleteCard(cardId);
                return true;

            }
        }

        public bool BorrowBook(int userId, int cardId, int bookId)
        {
            using (var dbBooks = new CtxBooks())
            {
                using (var dbUsers = new CtxUsers())
                {
                    if (dbBooks.IsBookBorrowed(bookId))
                    {
                        return false;
                    }

                    if (dbBooks.IsBookRemoved(bookId))
                    {
                        return false;
                    }

                    if (dbUsers.GetCardRents(cardId).Count == 3)
                    {
                        return false;
                    }

                    dbBooks.AddNewRent(bookId);
                    dbUsers.AddNewRent(bookId, cardId);
                }
            }

            return true;
        }

        public bool ProlongBook(int userId, int cardId, int bookId)
        {
            using (var db = new CtxUsers())
            {
                DataBase.Db.DbUsers.Models.Rent rent = db.GetBookRent(bookId);

                if (rent.Prolonged != 0) return false;

                if (DateTime.Now < rent.To.AddDays(-10)) return false;

                db.Prolong(rent.RentId);

                return true;
            }
        }

        public bool ReturnBook(int userId, int cardId, int bookId)
        {
            using (var db = new CtxBooks())
            {
                db.RemoveFromRents(bookId);
            }

            using (var db = new CtxUsers())
            {
                db.AddHistories(cardId, bookId);
                db.RemoveFromRents(bookId);
            }

            return true;
        }
    }
}
