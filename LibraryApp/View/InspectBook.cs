using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.Utils;

namespace LibraryApp.View
{
    // Todo:
    // standard labels representing book + price cmbBox
    public partial class InspectBook : Form
    {
        private readonly UsableBook _usableBook;
        private readonly string _path;
        private Currency _oldCurrency;
        public InspectBook(string path, UsableBook usableBook, Currency oldCurrency)
        {
            _oldCurrency = oldCurrency;
            _usableBook = usableBook;
            _path = path;
            InitializeComponent();
            LoadBookInfo();
            LoadBookPicture();
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

        private void LoadBookInfo()
        {
            LoadCurrencies();

            labelLanguageText.Text = _usableBook.Language;
            labelRatexText.Text = _usableBook.NumOfRatings.ToString();
            labelRatingText.Text = _usableBook.Rating.ToString(CultureInfo.InvariantCulture);
            labelAuthorText.Text = _usableBook.Author;
            labelDescriptionText.Text = _usableBook.Description;
            labelTitleText.Text = _usableBook.Title;
            labelSeriesText.Text = _usableBook.Series;
            labelPagesText.Text = _usableBook.Pages.ToString();
            labelFormatText.Text = _usableBook.BookFormat;
            labelPublisherText.Text = _usableBook.Publisher;
            labelPriceText.Text = _usableBook.Price.ToString(CultureInfo.InvariantCulture);

            foreach (string character in _usableBook.Characters)
            {
                labelCharactersText.Text += character + @",";
            }

            foreach (string genre in _usableBook.Genres)
            {
                labelGenresText.Text += genre + @",";
            }

            foreach (string setting in _usableBook.Setting)
            {
                labelSettingText.Text += setting + @",";
            }
        }

        private void LoadCurrencies()
        {
            using (var currencyCl = new ServiceCurrencyCalculatorClient())
            {
                foreach (Currency currency in currencyCl.GetCurrencies())
                {
                    comboBoxCurrencies.Items.Add(currency);
                }
            }

            foreach (Currency currency in comboBoxCurrencies.Items)
            {
                if (currency.Code != _oldCurrency.Code) continue;

                comboBoxCurrencies.SelectedIndex = comboBoxCurrencies.Items.IndexOf(currency);
                break;
            }
        }

        private void InspectBook_Load(object sender, System.EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            pictureBox.BackgroundImage.Dispose();
            Close();
        }

        private void comboBoxCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency newCurrency = (Currency)comboBoxCurrencies.SelectedItem;

            using (var currencyCl = new ServiceCurrencyCalculatorClient())
            {
                _usableBook.Price = currencyCl.CalculateCurrencyValue(_usableBook.Price, _oldCurrency.Code, newCurrency.Code);
                labelPriceText.Text = _usableBook.Price.ToString(CultureInfo.InvariantCulture);

                _oldCurrency = newCurrency;
            }
        }
    }
}
