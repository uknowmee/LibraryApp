using System;
using System.Collections.Generic;
using System.Linq;
using DataBase.Db.DbUsers.Models;
using DataBase.Utils;

namespace DataBase.Db.DbUsers.Context
{
    public partial class CtxUsers
    {
        public void AddAdmin(string adminName, PassHash passHash)
        {
            Users.Add(new User()
            {
                UserName = adminName,
                UserPassword = passHash.Password,
                Salt = passHash.Salt
            });

            SaveChanges();

            Admins.Add(new Admin()
            {
                UserId = Users.ToList()[Users.ToList().Count - 1].UserId
            });

            SaveChanges();
        }

        public bool DoesUserExist(string userName)
        {
            var uNames = Users.Select(u => u.UserName).ToList();

            return uNames.Any(s => s == userName);
        }

        public bool DoesUserPassMatch(string userName, string pass)
        {
            var users = Users.ToList();

            User user = users.Single(u => u.UserName == userName);
            PassHash passHash = new PassHash(pass, user.Salt);

            return passHash.Password == user.UserPassword;
        }

        public User AddNewUser(string userName, string password)
        {
            PassHash passHash = new PassHash(userName, password);

            Users.Add(new User()
            {
                UserName = userName,
                UserPassword = passHash.Password,
                Salt = passHash.Salt
            });

            SaveChanges();

            return Users.ToList()[Users.ToList().Count - 1];
        }

        public User GetUserByName(string userName)
        {
            var users = Users.ToList();

            return users.Single(u => u.UserName == userName);
        }

        public bool IsUserAdmin(int userId)
        {
            return Admins.Any(a => a.UserId == userId);
        }

        public List<Card> GetUserCards(int userId)
        {
            return Cards.Where(c => c.UserId == userId).ToList();
        }

        public List<Rent> GetUserRents(int userId)
        {
            var cards = GetUserCards(userId).Select(c => c.CardId).ToList();

            return Rents.Where(r => cards.Contains(r.CardId)).ToList();
        }

        public void AddNewUserCard(int userId, string ownerName, string ownerSurname)
        {
            Cards.Add(new Card()
            {
                OwnerName = ownerName,
                OwnerSurname = ownerSurname,
                UserId = userId
            });

            SaveChanges();
        }

        public List<Rent> GetCardRents(int cardId)
        {
            return Rents.Where(r => r.CardId == cardId).ToList();
        }

        public void DeleteCard(int cardId)
        {
            var card = Cards.Single(c => c.CardId == cardId);
            Cards.Remove(card);
            SaveChanges();
        }

        public void AddNewRent(int bookId, int cardId)
        {
            Rents.Add(new Rent()
            {
                BookId = bookId,
                CardId = cardId,
                From = DateTime.Now,
                To = DateTime.Now.AddMonths(1),
                Prolonged = 0
            });

            SaveChanges();
        }

        public Rent GetBookRent(int bookId)
        {
            return Rents.Single(r => r.BookId == bookId);
        }

        public void Prolong(int rentRentId)
        {
            Rent rent = Rents.Single(r => r.RentId == rentRentId);
            rent.Prolonged += 1;
            rent.To = rent.To.AddMonths(1);

            SaveChanges();
        }

        public void AddHistories(int cardId, int bookId)
        {
            Rent rent = GetBookRent(bookId);

            Histories.Add(new History()
            {
                BookId = bookId,
                CardId = cardId,
                From = rent.From,
                To = DateTime.Now
            });

            SaveChanges();
        }

        public void RemoveFromRents(int bookId)
        {
            Rent rent = Rents.Single(r => r.BookId == bookId);
            Rents.Remove(rent);
            SaveChanges();
        }
    }
}