using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryApp.Controller.User;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.ServiceLogin;
using LibraryApp.Utils;

namespace LibraryApp.View.User
{
    // Todo:
    // cmbBox books + link to Inspect
    public partial class History : Form
    {
        private readonly string _path;
        private readonly StdUser User;
        private readonly Currency _currency;
        private readonly List<UsableBook> _usableBooks;

        public History(StdUser loggedIn, string path, Currency currency)
        {
            _usableBooks = new List<UsableBook>();
            _currency = currency;
            User = loggedIn;
            _path = path;
            InitializeComponent();
            using (var loginCl = new ServiceLoginClient())
            {
                try
                {
                    using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                    {
                        var histories = loginCl.GetUserHistory(User.User.UserId);
                        foreach (var history in histories)
                        {
                            listBox.Items.Add("Card: " + loginCl.GetCardById(history.CardId) +
                                              ", From: " + history.From.ToShortDateString() + ", To: " +
                                              history.To.ToShortDateString() + ", Book Title: " +
                                              booksViewCl.GetUsableBookById(history.BookId).Title);
                            _usableBooks.Add(booksViewCl.GetUsableBookById(history.BookId));
                        }
                    }

                }
                catch (Exception)
                {
                    using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                    {

                        var histories = loginCl.GetUserHistory(User.User.UserId);
                        foreach (var history in histories)
                        {
                            listBox.Items.Add("Card: " + loginCl.GetCardById(history.CardId) +
                                              ", From: " + history.From.ToShortDateString() + ", To: " +
                                              history.To.ToShortDateString() + ", Book Title: " +
                                              booksViewCl.GetUsableBookById(history.BookId).Title);
                            _usableBooks.Add(booksViewCl.GetUsableBookById(history.BookId));
                        }
                    }
                }
            }
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.Text == "") return;
            new InspectBook(_path, _usableBooks[listBox.SelectedIndex], _currency).ShowDialog();
        }
    }
}
