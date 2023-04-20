using System;
using System.Windows.Forms;
using LibraryApp.Controller.User;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.ServiceLogin;
using LibraryApp.Utils;

namespace LibraryApp.View.User
{
    // Todo:
    // list of all rented books (if returned)
    public partial class Rented : Form
    {
        private readonly string _path;
        public readonly StdUser User;
        private UsableBook _selectedBook;
        private readonly Currency _currency;

        public Rented(StdUser loggedIn, string path, Currency currency)
        {
            _currency = currency;
            _selectedBook = null;
            User = loggedIn;
            _path = path;
            InitializeComponent();
            LoadData();
        }

        private void LoadCardBooks()
        {
            listBox.Items.Clear();
            listBoxFrom.Items.Clear();

            if (User.SelectedCard == null) return;

            if (!User.Rented.ContainsKey(User.SelectedCard.CardId)) return;

            foreach (StdUser.Rent rent in User.Rented[User.SelectedCard.CardId])
            {
                listBox.Items.Add(rent.RentedBook);
                listBoxFrom.Items.Add("From: " + rent.RentedFrom.ToShortDateString() + ", To: " + rent.RentedTo.ToShortDateString());
            }
        }

        private void LoadData()
        {
            foreach (Card card in User.Cards)
            {
                comboBoxOnCard.Items.Add(card);
            }

            if (User.SelectedCard == null) return;

            foreach (Card card in comboBoxOnCard.Items)
            {
                if (User.SelectedCard != card) continue;
                comboBoxOnCard.SelectedIndex = comboBoxOnCard.Items.IndexOf(card);
                break;
            }

            LoadCardBooks();
        }

        private void Rented_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void comboBoxOnCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBoxOnCard.SelectedItem is Card card)) return;

            User.SelectedCard = card;

            LoadCardBooks();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBox.SelectedItem is UsableBook uBook)) return;

            _selectedBook = uBook;
        }

        private void buttonProlong_Click(object sender, EventArgs e)
        {
            if (!(listBox.SelectedItem is UsableBook uBook)) return;

            if (!User.Prolong(uBook))
            {
                MessageBox.Show(@"Didn't prolong!");
                return;
            }

            LoadCardBooks();
            MessageBox.Show(@"Prolonged!");
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (!(listBox.SelectedItem is UsableBook uBook)) return;

            if (!User.ReturnBook(uBook))
            {
                MessageBox.Show(@"Didn't return!");
                return;
            }

            LoadCardBooks();
            MessageBox.Show(@"Returned!");
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (!(listBox.Items[listBox.SelectedIndex] is UsableBook uBook)) return;
            new InspectBook(_path, uBook, _currency).ShowDialog();
        }
    }
}
