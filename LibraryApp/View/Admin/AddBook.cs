using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using LibraryApp.ServiceBookManagement;
using LibraryApp.ServiceBooksView;
using LibraryApp.Utils;
using Newtonsoft.Json;

namespace LibraryApp.View.Admin
{
    public partial class AddBook : Form
    {
        // Todo:
        // view of book building
        //textBoxGenres.Text = JsonConvert.DeserializeObject<List<string>>(_usableBook.Genres);


        // - title, series?, author, rating, description, bookFormat, pages, Publisher, num ratings, coverImg(url), price => txtBox
        // - language => cmbBox
        // - genre => cmbBox (a->z), complete genre => cmbBox, selected genres => list
        // - characters, selected characters
        // - setting, selected setting
        private readonly string _path;
        private readonly Controller.User.Admin _admin;
        private readonly UsableBook _usableBook;

        public AddBook(Controller.User.Admin admin, string path, UsableBook selectedBook)
        {
            _admin = admin;
            _path = path;
            _usableBook = selectedBook;

            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            if (_usableBook == null) return;

            textBoxRating.Text = _usableBook.Rating.ToString(CultureInfo.InvariantCulture);
            textBoxLanguage.Text = _usableBook.Language;
            textBoxRates.Text = _usableBook.NumOfRatings.ToString();
            textBoxAuthor.Text = _usableBook.Author;
            textBoxPrice.Text = _usableBook.Price.ToString(CultureInfo.InvariantCulture);
            textBoxCharacters.Text = JsonConvert.SerializeObject(_usableBook.Characters);
            textBoxGenres.Text = JsonConvert.SerializeObject(_usableBook.Genres);
            textBoxSetting.Text = JsonConvert.SerializeObject(_usableBook.Setting);
            textBoxDescription.Text = _usableBook.Description;

            textBoxTitle.Text = _usableBook.Title;
            textBoxSeries.Text = _usableBook.Series;
            textBoxPages.Text = _usableBook.Pages.ToString();
            textBoxFormat.Text = _usableBook.BookFormat;
            textBoxPublisher.Text = _usableBook.Publisher;
            textBoxLink.Text = _usableBook.CoverImg;

            LoadBookPicture();
        }

        private void AddBook_Load(object sender, System.EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, System.EventArgs e)
        {
            using (var bookManagementCl = new ServiceBookManagementClient())
            {
                if (_usableBook == null)
                {
                    bookManagementCl.AddNewBook(textBoxRating.Text, textBoxLanguage.Text, textBoxRates.Text, textBoxAuthor.Text,
                        textBoxPrice.Text, textBoxCharacters.Text, textBoxGenres.Text, textBoxSetting.Text, textBoxDescription.Text, textBoxTitle.Text, 
                        textBoxSeries.Text, textBoxPages.Text, textBoxFormat.Text,textBoxPublisher.Text,textBoxLink.Text);
                }
                else
                {
                    bookManagementCl.EditBook(_usableBook.BookId, textBoxRating.Text, textBoxLanguage.Text, textBoxRates.Text, textBoxAuthor.Text,
                        textBoxPrice.Text, textBoxCharacters.Text, textBoxGenres.Text, textBoxSetting.Text, textBoxDescription.Text, textBoxTitle.Text,
                        textBoxSeries.Text, textBoxPages.Text, textBoxFormat.Text, textBoxPublisher.Text, textBoxLink.Text);
                }
            }
        }

        private static string MakeExecPath(string execPath)
        {
            List<string> strings = execPath.Split('\\').ToList();

            strings.RemoveAt(strings.Count - 1);

            string newPath = strings[0];
            strings.RemoveAt(0);

            newPath = strings.Aggregate(newPath, (current, s) => current + ("\\" + s));

            return newPath + "\\";
        }

        private static string FixBookTitle(string title)
        {
            List<string> forbiddenChars = new List<string>() { "<", ">", ":", "\"", "/", "\\", "|", "?", "*", ".", " " };


            return forbiddenChars
                .Aggregate(title, (current, forbiddenChar) => current
                    .Replace(forbiddenChar, "_"));
        }

        private void LoadBookPicture()
        {
            string execPath = Assembly.GetEntryAssembly()?.Location;
            string filePath = @"../../BooksPictures/" + FixBookTitle(_usableBook.Title) + ".png";
            string runFilePath = MakeExecPath(execPath) + filePath;

            using (WebClient webClient = new WebClient())
            {
                byte[] dataArr = webClient.DownloadData(_usableBook.CoverImg);
                File.WriteAllBytes(filePath, dataArr);
            }

            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.BackgroundImage = Image.FromFile(runFilePath);
        }
    }
}
