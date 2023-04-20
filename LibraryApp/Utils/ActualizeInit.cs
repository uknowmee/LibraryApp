using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using LibraryApp.Controller.User;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceCurrencyCalculator;
using LibraryApp.View;
using Currency = LibraryApp.ServiceCurrencyCalculator.Currency;

namespace LibraryApp.Utils
{
    public static class ActualizeInit
    {
        private static readonly List<string> ForUser = new List<string>() { "buttonHistory", "buttonSubscriptions",
            "buttonNotifications", "buttonCards", "buttonRentedBooks", "buttonBorrowBook", "labelPending"};

        private static readonly List<string> ForAdmin = new List<string>() { "buttonAddBook", "buttonEditBook",
            "buttonDeleteBook", "buttonRentHistory", "labelPending"};

        private static readonly List<UsableBook> UBooks = new List<UsableBook>();

        public static string ActualizeLoggedIn(this InitPanel form)
        {
            if (form.LoggedIn == null)
            {
                return GuestActualize(form);
            }

            return form.LoggedIn.GetType() == typeof(StdUser) ? UserActualize(form) : AdminActualize(form);
        }

        private static string UserActualize(InitPanel form)
        {
            foreach (Control control in form.Controls)
            {
                control.Visible = !ForAdmin.Contains(control.Name);
            }
            return ((StdUser)form.LoggedIn).ToString();
        }

        private static string AdminActualize(InitPanel form)
        {
            foreach (Control control in form.Controls)
            {
                control.Visible = !ForUser.Contains(control.Name);
            }

            return ((Admin)form.LoggedIn).ToString();
        }

        private static string GuestActualize(InitPanel form)
        {
            foreach (Control control in form.Controls)
            {
                if (ForUser.Contains(control.Name) || ForAdmin.Contains(control.Name))
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

            return "";
        }

        public static ListBox ActualizeFilteredBooks(this InitPanel form, string titleAuthor, int maxPrice, int minPrice,
            int maxPages, int minPages, ComboBox.ObjectCollection genres, Currency currency, string language, ListBox listBox)
        {
            string[] validGenres = (from object genre in genres select genre.ToString()).ToArray();
            UBooks.Clear();
            listBox.Items.Clear();

            try
            {
                using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                {
                    foreach (UsableBook uBook in booksViewCl.GetBooksFiltered(titleAuthor, maxPrice, minPrice, maxPages, minPages, validGenres, language))
                    {
                        UBooks.Add(uBook);
                    }

                }
            }
            catch (Exception)
            {
                using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                {
                    foreach (UsableBook uBook in booksViewCl.GetBooksFiltered(titleAuthor, maxPrice, minPrice, maxPages, minPages, validGenres, language))
                    {
                        UBooks.Add(uBook);
                    }
                }
            }

            CalcCurrencyOfFilteredBooks(currency.Code);

            foreach (UsableBook usableBook in UBooks)
            {
                listBox.Items.Add(usableBook);
            }

            listBox.Items.Add("Records: " + UBooks.Count);

            return listBox;
        }

        private static void CalcCurrencyOfFilteredBooks(string currencyCode)
        {
            using (var currencyCl = new ServiceCurrencyCalculatorClient())
            {
                float oldCurrency = currencyCl.GetCurrencyByCode("EUR").Value;
                Currency newCurrency = currencyCl.GetCurrencyByCode(currencyCode);

                foreach (UsableBook usableBook in UBooks)
                {
                    usableBook.Price = usableBook.Price * oldCurrency / newCurrency.Value;
                }
            }
        }

        public static ComboBox GetCurrencyTypes(this InitPanel form, ComboBox currencyType)
        {
            currencyType.Items.Clear();

            using (var currencyCl = new ServiceCurrencyCalculatorClient())
            {
                foreach (Currency currency in currencyCl.GetCurrencies())
                {
                    currencyType.Items.Add(currency);
                }
            }

            foreach (Currency currency in currencyType.Items)
            {
                if (!Currency.IsEur(currency)) continue;

                currencyType.SelectedIndex = currencyType.Items.IndexOf(currency);
                break;
            }

            return currencyType;
        }

        public static ComboBox GetFirstGenreLetters(this Form form, ComboBox comboBoxGenreFl)
        {
            comboBoxGenreFl.Items.Clear();

            comboBoxGenreFl.Items.Add("Empty");
            for (int i = 1; i < 10; i++)
            {
                comboBoxGenreFl.Items.Add(i);
            }

            char[] az = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
            foreach (var c in az)
            {
                comboBoxGenreFl.Items.Add(c);
            }

            return comboBoxGenreFl;
        }

        public static ComboBox GetGenresByFirstLetter(this Form form, ComboBox comboBoxGenre, string firstLetter)
        {
            comboBoxGenre.Items.Clear();

            try
            {
                using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                {
                    foreach (string genre in booksViewCl.GetGenresByFirstLetter(firstLetter))
                    {
                        comboBoxGenre.Items.Add(genre);
                    }

                }
            }
            catch (Exception)
            {
                using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                {
                    foreach (string genre in booksViewCl.GetGenresByFirstLetter(firstLetter))
                    {
                        comboBoxGenre.Items.Add(genre);
                    }

                }
            }

            return comboBoxGenre;
        }

        public static ComboBox GetLanguages(this Form form, ComboBox comboBoxLanguage)
        {
            comboBoxLanguage.Items.Clear();

            try
            {
                using (var booksViewCl = new ServiceBooksViewClient("BasicHttpBinding_IServiceBooksView"))
                {
                    foreach (string language in booksViewCl.GetLanguages())
                    {
                        comboBoxLanguage.Items.Add(language);
                    }

                }
            }
            catch (Exception)
            {
                using (var booksViewCl = new ServiceBooksViewClient("WSHttpBinding_IServiceBooksView"))
                {
                    foreach (string language in booksViewCl.GetLanguages())
                    {
                        comboBoxLanguage.Items.Add(language);
                    }

                }
            }

            return comboBoxLanguage;
        }
    }
}