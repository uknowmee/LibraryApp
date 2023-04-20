using System;
using System.Windows.Forms;
using LibraryApp.Controller.User;
using LibraryApp.ServiceLogin;
using LibraryApp.Utils;

namespace LibraryApp.View.User
{
    public partial class Cards : Form
    {
        private readonly string _path;
        public readonly StdUser User;
        public Cards(StdUser loggedIn, string path)
        {
            User = loggedIn;
            _path = path;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            textBoxNewCardOwnerName.Text = "";
            textBoxNewCardOwnerSurname.Text = "";

            comboBoxSelectedCard.Items.Clear();

            foreach (Card userCard in User.Cards)
            {
                comboBoxSelectedCard.Items.Add(userCard);
            }

            if (User.SelectedCard != null)
            {
                comboBoxSelectedCard.SelectedIndex = comboBoxSelectedCard.Items.IndexOf(User.SelectedCard);
            }
        }

        private void Cards_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNewCardOwnerName.Text = "";
            textBoxNewCardOwnerSurname.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!(comboBoxSelectedCard.SelectedItem is Card card)) return;

            if (!User.DeleteCard())
            {
                MessageBox.Show(@"You cant delete", String.Empty, MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show(@"Card deleted", String.Empty, MessageBoxButtons.OK);
            LoadData();
        }

        private void buttonAddNewCard_Click(object sender, EventArgs e)
        {
            if (textBoxNewCardOwnerSurname.Text == textBoxNewCardOwnerName.Text ||
                textBoxNewCardOwnerSurname.Text == "" || textBoxNewCardOwnerName.Text =="")
            {
                return;
            }

            if (!User.AddNewCard(textBoxNewCardOwnerName.Text, textBoxNewCardOwnerSurname.Text))
            {
                MessageBox.Show(@"Cant add", String.Empty, MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show(@"Card added", String.Empty, MessageBoxButtons.OK);
            LoadData();
        }

        private void comboBoxSelectedCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBoxSelectedCard.SelectedItem is Card card)) return;

            User.SelectedCard = card;
        }
    }
}
