using System;
using System.Windows.Forms;
using LibraryApp.Controller.User;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceSubscriptions;
using LibraryApp.Utils;

namespace LibraryApp.View.User
{
    // Todo:
    // - all? or: genre => cmbBox (a->z), complete genre => cmbBox, selected genres => list
    // - new / returned
    public partial class Subscribe : Form
    {
        private readonly string _path;
        private readonly StdUser _user;
        public Subscribe(StdUser loggedIn, string path)
        {
            _user = loggedIn;
            _path = path;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var subscriptionCl = new ServiceSubscriptionsClient())
            {
                comboBoxOldSubscriptions.Items.Clear();
                foreach (Subscription subscription in subscriptionCl.GetUserSubscriptions(_user.User.UserId))
                {
                    comboBoxOldSubscriptions.Items.Add(subscription);
                }
            }

            comboBoxGenre.Items.Clear();
            try
            {
                using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                {
                    foreach (string genre in booksViewCl.GetGenres())
                    {
                        comboBoxGenre.Items.Add(genre);
                    }
                }
            }
            catch (Exception)
            {
                using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                {
                    foreach (string genre in booksViewCl.GetGenres())
                    {
                        comboBoxGenre.Items.Add(genre);
                    }
                }
            }
        }

        private void Subscribe_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(!(comboBoxOldSubscriptions.SelectedItem is Subscription subscription)) return;

            _user.DeleteSubscription(subscription.SubscriptionId);
            LoadData();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboBoxGenre.Text == "") return;

            if (_user.AddSubscription(checkBoxNew.Checked, checkBoxReturned.Checked, comboBoxGenre.Text))
            {
                    LoadData();
            }
        }
    }
}
