using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceLogin;
using LibraryApp.ServiceNotifications;
using LibraryApp.ServiceRent;
using LibraryApp.ServiceSubscriptions;
using Card = LibraryApp.ServiceLogin.Card;
using UsableBook = LibraryApp.ServiceBooksView.UsableBook;

namespace LibraryApp.Controller.User
{
    // Todo:
    // Base user permissions and functions
    public class StdUser : UsableUser
    {
        public class Rent
        {
            public readonly UsableBook RentedBook;
            public DateTime RentedFrom;
            public DateTime RentedTo;

            public Rent(UsableBook usableBook, DateTime rentedFrom, DateTime rentedTo)
            {
                RentedBook = usableBook;
                RentedFrom = rentedFrom;
                RentedTo = rentedTo;

            }
        }

        public List<Card> Cards { get; private set; }
        public Card SelectedCard { get; set; }
        public Dictionary<int, List<Rent>> Rented { get; private set; }
        public StdUser(ServiceLogin.User user) : base(user)
        {
            using (var loginCl = new ServiceLoginClient())
            {
                Cards = new List<Card>(loginCl.GetUserCards(User.UserId));
                SelectedCard = Cards.Count == 0 ? null : Cards[0];
            }

            ActualizeRents();
        }

        public override string ToString()
        {
            if (SelectedCard == null)
            {
                return "Your Login: " + User.UserName + ", Selected Card:";
            }

            return "Your Login: " + User.UserName + ", Selected Card: " + SelectedCard.ToString();
        }

        private void ActualizeCards()
        {
            using (var loginCl = new ServiceLoginClient())
            {
                Cards = new List<Card>(loginCl.GetUserCards(User.UserId));

                if (SelectedCard == null) return;

                if (!Cards.Contains(SelectedCard))
                {
                    SelectedCard = Cards.Count == 0 ? null : Cards[0];
                }
            }
        }

        private void ActualizeRents()
        {
            using (var rentCl = new ServiceRentClient())
            {
                if (Cards.Count == 0)
                {
                    Rented = null;
                }
                else
                {
                    Rented = new Dictionary<int, List<Rent>>();
                    try
                    {
                        using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                        {
                            foreach (ServiceRent.Rent rent in rentCl.GetUserRents(User.UserId))
                            {
                                if (!Rented.Keys.Contains(rent.CardId))
                                {
                                    Rented.Add(rent.CardId, new List<Rent>());
                                }

                                Rented[rent.CardId].Add(new Rent(booksViewCl.GetUsableBookById(rent.BookId), rent.From, rent.To));
                            }
                        }
                    }
                    catch (Exception)
                    {
                        using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                        {
                            foreach (ServiceRent.Rent rent in rentCl.GetUserRents(User.UserId))
                            {
                                if (!Rented.Keys.Contains(rent.CardId))
                                {
                                    Rented.Add(rent.CardId, new List<Rent>());
                                }

                                Rented[rent.CardId].Add(new Rent(booksViewCl.GetUsableBookById(rent.BookId), rent.From, rent.To));
                            }
                        }
                    }
                }
            }
        }

        public bool AddNewCard(string ownerName, string ownerSurname)
        {
            using (var rentCl = new ServiceRentClient())
            {
                if (!rentCl.AddNewCard(User.UserId, ownerName, ownerSurname)) return false;

                ActualizeCards();
                ActualizeRents();
                return true;

            }
        }

        public bool DeleteCard()
        {
            using (var rentCl = new ServiceRentClient())
            {
                if (!rentCl.DeleteCard(SelectedCard.CardId)) return false;

                ActualizeCards();
                ActualizeRents();
                return true;
            }
        }

        public bool BorrowBook(UsableBook usableBook)
        {
            if (SelectedCard == null) return false;

            using (var rentCl = new ServiceRentClient())
            {
                if (!rentCl.BorrowBook(User.UserId, SelectedCard.CardId, usableBook.BookId)) return false;

                ActualizeRents();
                return true;
            }
        }

        public bool ReturnBook(UsableBook usableBook)
        {
            using (var rentCl = new ServiceRentClient())
            {
                if (!rentCl.ReturnBook(User.UserId, SelectedCard.CardId, usableBook.BookId)) return false;

                ActualizeRents();
                using (var notificationCl = new ServiceNotificationsClient())
                {
                    notificationCl.SendNotificationsReturned(usableBook.BookId, User.UserId);
                }
                return true;
            }
        }

        public bool Prolong(UsableBook usableBook)
        {
            using (var rentCl = new ServiceRentClient())
            {
                if (!rentCl.ProlongBook(User.UserId, SelectedCard.CardId, usableBook.BookId)) return false;

                ActualizeRents();
                return true;
            }
        }

        public void DeleteNotification(int notificationId)
        {
            using (var notificationsCl = new ServiceNotificationsClient())
            {
                notificationsCl.RemoveNotification(notificationId);
            }
        }

        public void DeleteSubscription(int subscriptionId)
        {
            using (var subscriptionCl = new ServiceSubscriptionsClient())
            {
                subscriptionCl.DeleteSubscription(subscriptionId);
            }
        }

        public bool AddSubscription(bool isNew, bool isReturned, string genre)
        {
            using (var subscriptionCl = new ServiceSubscriptionsClient())
            {
                return subscriptionCl.AddSubscription(isNew, isReturned, User.UserId, genre);
            }
        }
    }
}