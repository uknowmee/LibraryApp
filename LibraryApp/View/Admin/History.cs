using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.ServiceLogin;
using LibraryApp.Utils;

namespace LibraryApp.View.Admin
{
    // Todo:
    // cmbBox users + list view of books + link to Inspect
    public partial class History : Form
    {
        private readonly string _path;
        private readonly Controller.User.Admin _user;
        private readonly Currency _currency;
        private readonly List<UsableBook> _usableBooks;

        public History(Controller.User.Admin loggedIn, string path, Currency currency)
        {
            _user = loggedIn;
            _usableBooks = new List<UsableBook>();
            _currency = currency;
            _path = path;
            InitializeComponent();
            ScanUser();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.Text == "") return;
            new InspectBook(_path, _usableBooks[listBox.SelectedIndex], _currency).ShowDialog();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBoxUser.SelectedItem is ServiceLogin.User user)) return;

            LoadData(user);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void ScanUser()
        {
            using (var loginCl = new ServiceLoginClient())
            {
                comboBoxUser.Items.Clear();
                foreach (ServiceLogin.User user in loginCl.GetUsersNonAdmin())
                {
                    comboBoxUser.Items.Add(user);
                }
            }
        }

        private void LoadData(ServiceLogin.User user)
        {
            listBox.Items.Clear();
            _usableBooks.Clear();

            using (var loginCl = new ServiceLoginClient())
            {
                try
                {
                    using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                    {
                        var histories = loginCl.GetUserHistory(user.UserId);
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

                        var histories = loginCl.GetUserHistory(user.UserId);
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
    }
}
