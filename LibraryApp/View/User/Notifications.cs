using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryApp.Controller.User;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.ServiceNotifications;
using LibraryApp.Utils;
using UsableBook = LibraryApp.ServiceBooksView.UsableBook;

namespace LibraryApp.View.User
{
    // Todo:
    // list of all notifications based on datetime possible to delete or click "seen"
    public partial class Notifications : Form
    {
        private readonly string _path;
        private readonly StdUser _user;
        private readonly Currency _currency;
        private readonly List<UsableBook> _usableBooks;
        private List<Notification> _notifications;
        public Notifications(StdUser loggedIn, string path, Currency currency)
        {
            _usableBooks = new List<UsableBook>();
            _currency = currency;
            _user = loggedIn;
            _path = path;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var notificationCl = new ServiceNotificationsClient())
            {
                foreach (var usableBook in notificationCl.TimeIsEnding(_user.User.UserId))
                {
                    MessageBox.Show($@"Time of rent is ending!{usableBook.Title}", String.Empty);
                }

                _notifications = new List<Notification>(notificationCl.GetUserNotifications(_user.User.UserId));
                try
                {
                    using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                    {
                        foreach (var notification in _notifications)
                        {
                            listBox.Items.Add(
                                notification.ToReturn
                                    ? $@"To return soon: {notification.Appear.ToShortDateString()}, Title: {booksViewCl.GetUsableBookById(notification.BookId)}"
                                    : $@"Appear: {notification.Appear.ToShortDateString()}, Title: {booksViewCl.GetUsableBookById(notification.BookId)}");
                            _usableBooks.Add(booksViewCl.GetUsableBookById(notification.BookId));
                        }
                    }
                }
                catch (Exception)
                {
                    using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                    {

                        foreach (var notification in _notifications)
                        {
                            listBox.Items.Add(
                                notification.ToReturn
                                    ? $@"To return soon: {notification.Appear.ToShortDateString()}, Title: {booksViewCl.GetUsableBookById(notification.BookId)}"
                                    : $@"Appear: {notification.Appear.ToShortDateString()}, Title: {booksViewCl.GetUsableBookById(notification.BookId)}");
                            _usableBooks.Add(booksViewCl.GetUsableBookById(notification.BookId));
                        }
                    }
                }
            }
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.Text == "") return;
            new InspectBook(_path, _usableBooks[listBox.SelectedIndex], _currency).ShowDialog();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox.Text == "") return;

            int index = listBox.SelectedIndex;

            _user.DeleteNotification(_notifications[index].NotificationId);

            listBox.Items.RemoveAt(index);
            _usableBooks.RemoveAt(index);
            _notifications.RemoveAt(index);
        }
    }
}
