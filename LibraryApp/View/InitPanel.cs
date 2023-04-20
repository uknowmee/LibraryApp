using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryApp.Controller.User;
using LibraryApp.ServiceBookManagement;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.Utils;
using LibraryApp.View.Admin;
using LibraryApp.View.User;
using History = LibraryApp.View.User.History;

namespace LibraryApp.View
{
    // 1552;880
    // 1166;716
    // TODO:
    // general book filtering form
    // - title + author => txtBox regex
    // - price range => trackBar
    // - num of pages => trackBar
    // - genre => cmbBox (a->z), complete genre => cmbBox, selected genres => list
    // - currency type => cmbBox

    // fRegister <- only for users (def admin: admin, admin), fLogin, fInspect

    // fAdd book + fEdit Book + Delete Book + fHistory (retractable)

    // Borrow Book + fRented + fHistory + fNotifications + fSubscribe (retractable)
    public partial class InitPanel : Form
    {
        private readonly string _path;
        public UsableUser LoggedIn;
        private bool _isResetFiltersUp;
        private bool _forceChange;
        private UsableBook _selectedBook;

        public InitPanel()
        {
            _selectedBook = null;
            _isResetFiltersUp = false;
            _forceChange = false;
            LoggedIn = null;
            _path = "../../Pictures/Background.jpg";

            InitializeComponent();
            ResetFilters();
            labelLoggedIn.Text = this.ActualizeLoggedIn();

            labelPending.Location = new Point(Width / 2 - labelPending.Width / 2, Height / 2 - labelPending.Height / 2);
            labelPending.Hide();
        }

        private void InitPanel_Load(object sender, EventArgs e)
        {
            this.SetMaxWindow(_path);
        }

        private void ResetFilters()
        {
            _isResetFiltersUp = true;

            checkBoxMaxPages.Checked = false;
            checkBoxMaxPrice.Checked = false;
            checkBoxMinPages.Checked = false;
            checkBoxMinPrice.Checked = false;

            trackBarMaxPages.Value = trackBarMaxPages.Maximum;
            trackBarMaxPrice.Value = trackBarMaxPrice.Maximum;

            trackBarMaxPages.Visible = false;
            trackBarMaxPrice.Visible = false;
            trackBarMinPages.Visible = false;
            trackBarMinPrice.Visible = false;

            labelMaxPages.Text = "";
            labelMaxPrice.Text = "";
            labelMinPages.Text = "";
            labelMinPrice.Text = "";

            textBoxTitleAuthor.Text = "";
            comboBoxCurrencyType = this.GetCurrencyTypes(comboBoxCurrencyType);
            comboBoxGenreFl = this.GetFirstGenreLetters(comboBoxGenreFl);
            comboBoxLanguage = this.GetLanguages(comboBoxLanguage);
            comboBoxGenre.Items.Clear();
            comboBoxSelectedGenres.Items.Clear();
            _isResetFiltersUp = false;
        }

        private void trackBarMaxPrice_Scroll(object sender, EventArgs e)
        {
            trackBarMinPrice.Maximum = trackBarMaxPrice.Value;
            labelMaxPrice.Text = trackBarMaxPrice.Value.ToString();
        }

        private void trackBarMinPrice_Scroll(object sender, EventArgs e)
        {
            trackBarMaxPrice.Minimum = trackBarMinPrice.Value;
            labelMinPrice.Text = trackBarMinPrice.Value.ToString();
        }

        private void trackBarMaxPages_Scroll(object sender, EventArgs e)
        {
            trackBarMinPages.Maximum = trackBarMaxPages.Value;
            labelMaxPages.Text = trackBarMaxPages.Value.ToString();
        }

        private void trackBarMinPages_Scroll(object sender, EventArgs e)
        {
            trackBarMaxPages.Minimum = trackBarMinPages.Value;
            labelMinPages.Text = trackBarMinPages.Value.ToString();
        }

        private void checkBoxMaxPrice_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(true, (CheckBox)sender);

            if (((CheckBox)sender).Checked)
            {
                trackBarMaxPrice.Visible = true;
                labelMaxPrice.Visible = true;
            }
            else
            {
                trackBarMaxPrice.Visible = false;
                labelMaxPrice.Visible = false;
            }
            trackBarMaxPrice.Value = trackBarMaxPrice.Maximum;
            trackBarMinPrice.Maximum = trackBarMaxPrice.Value;
            labelMaxPrice.Text = trackBarMaxPrice.Value.ToString();
        }

        private void checkBoxMinPrice_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(true, (CheckBox)sender);

            if (((CheckBox)sender).Checked)
            {
                trackBarMinPrice.Visible = true;
                labelMinPrice.Visible = true;
            }
            else
            {
                trackBarMinPrice.Visible = false;
                labelMinPrice.Visible = false;
            }
            trackBarMinPrice.Value = trackBarMinPrice.Minimum;
            trackBarMaxPrice.Minimum = trackBarMinPrice.Value;
            labelMinPrice.Text = trackBarMinPrice.Value.ToString();

        }

        private void checkBoxMaxPages_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(true, (CheckBox)sender);

            if (((CheckBox)sender).Checked)
            {
                trackBarMaxPages.Visible = true;
                labelMaxPages.Visible = true;
            }
            else
            {
                trackBarMaxPages.Visible = false;
                labelMaxPages.Visible = false;
            }
            trackBarMaxPages.Value = trackBarMaxPages.Maximum;
            trackBarMinPages.Maximum = trackBarMaxPages.Value;
            labelMaxPages.Text = trackBarMaxPages.Value.ToString();
        }

        private void checkBoxMinPages_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(true, (CheckBox)sender);

            if (((CheckBox)sender).Checked)
            {
                trackBarMinPages.Visible = true;
                labelMinPages.Visible = true;
            }
            else
            {
                trackBarMinPages.Visible = false;
                labelMinPages.Visible = false;
            }
            trackBarMinPages.Value = trackBarMinPages.Minimum;
            trackBarMaxPages.Minimum = trackBarMinPages.Value;
            labelMinPages.Text = trackBarMinPages.Value.ToString();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (LoggedIn != null) return;

            new Register(_path).ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoggedIn != null) return;

            var response = new Login(_path);
            response.ShowDialog();

            if (response.Quited) return;

            LoggedIn = UsableUser.TryLoginUser(response.User, LoggedIn);

            labelLoggedIn.Text = this.ActualizeLoggedIn();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoggedIn = UsableUser.TryLoginUser(null, LoggedIn);

            labelLoggedIn.Text = this.ActualizeLoggedIn();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            listBox = this.ActualizeFilteredBooks(textBoxTitleAuthor.Text, trackBarMaxPrice.Value,
                trackBarMinPrice.Value, trackBarMaxPages.Value, trackBarMinPages.Value, comboBoxSelectedGenres.Items,
                (Currency)comboBoxCurrencyType.SelectedItem, comboBoxLanguage.Text, listBox);

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }

        private void comboBoxGenreFl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isResetFiltersUp) return;

            if (comboBoxGenreFl.Text == @"Empty")
            {
                comboBoxGenre.Items.Clear();
                comboBoxSelectedGenres.Items.Add("Empty");
                return;
            }

            comboBoxGenre = this.GetGenresByFirstLetter(comboBoxGenre, comboBoxGenreFl.Text);
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isResetFiltersUp || _forceChange) return;

            if (comboBoxSelectedGenres.Items.Contains(comboBoxGenre.Text)) return;

            comboBoxSelectedGenres.Items.Add(comboBoxGenre.Text);
            _forceChange = true;
            comboBoxGenre.SelectedIndex = -1;
            _forceChange = false;
        }

        private void comboBoxSelectedGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isResetFiltersUp) return;

            comboBoxSelectedGenres.Items.RemoveAt(comboBoxSelectedGenres.SelectedIndex);
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(listBox.Items[listBox.SelectedIndex] is UsableBook uBook)) return;
            new InspectBook(_path, uBook, (Currency)comboBoxCurrencyType.SelectedItem).ShowDialog();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBox.Items[listBox.SelectedIndex] is UsableBook uBook)) return;
            _selectedBook = uBook;
        }

        private void buttonCards_Click(object sender, EventArgs e)
        {
            var response = new Cards((StdUser)LoggedIn, _path);
            response.ShowDialog();
            LoggedIn = response.User;

            labelLoggedIn.Text = LoggedIn.ToString();
        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null) return;

            var result = MessageBox.Show($@"Do you want to borrow:{_selectedBook}?", String.Empty, MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            if (!((StdUser)LoggedIn).BorrowBook(_selectedBook))
            {
                MessageBox.Show(@"you cant borrow!", String.Empty, MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show(@"You have borrowed a book", String.Empty, MessageBoxButtons.OK);
        }

        private void buttonRentedBooks_Click(object sender, EventArgs e)
        {
            var response = new Rented((StdUser)LoggedIn, _path, (Currency)comboBoxCurrencyType.SelectedItem);
            response.ShowDialog();
            LoggedIn = response.User;

            labelLoggedIn.Text = LoggedIn.ToString();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            new History((StdUser)LoggedIn, _path, (Currency)comboBoxCurrencyType.SelectedItem).ShowDialog();
        }

        private void buttonNotifications_Click(object sender, EventArgs e)
        {
            new Notifications((StdUser)LoggedIn, _path, (Currency)comboBoxCurrencyType.SelectedItem).ShowDialog();
        }

        private void buttonSubscriptions_Click(object sender, EventArgs e)
        {
            new Subscribe((StdUser)LoggedIn, _path).ShowDialog();
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null) return;

            new AddBook((Controller.User.Admin)LoggedIn, _path, _selectedBook).ShowDialog();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            new AddBook((Controller.User.Admin)LoggedIn, _path, null).ShowDialog();
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            ((Controller.User.Admin)LoggedIn).DeleteBook(_selectedBook);
        }

        private void buttonRentHistory_Click(object sender, EventArgs e)
        {
            new Admin.History((Controller.User.Admin)LoggedIn, _path, (Currency)comboBoxCurrencyType.SelectedItem).ShowDialog();
        }
    }
}
