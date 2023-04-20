using System;
using System.Windows.Forms;
using LibraryApp.ServiceBookManagement;
using LibraryApp.ServiceBooksView;

namespace LibraryApp.Controller.User
{
    // Todo:
    // Base admin permissions and functions
    public class Admin : UsableUser
    {
        public Admin(ServiceLogin.User user) : base(user)
        {
        }

        public override string ToString()
        {
            return "Your Login: " + User.UserName + ", Account Type: Admin.";
        }

        public void DeleteBook(UsableBook selectedBook)
        {
            if (selectedBook == null) return;

            using (var bookManagementCl = new ServiceBookManagementClient())
            {
                if (!bookManagementCl.IsBookDeleted(selectedBook.BookId))
                {
                    var result = MessageBox.Show($@"Do you want to delete: {selectedBook}?", String.Empty, MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;

                    if (!bookManagementCl.DeleteBook(selectedBook.BookId))
                    {
                        MessageBox.Show(@"You cant delete book", String.Empty, MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show(@"You have delete book", String.Empty, MessageBoxButtons.OK);
                }
                else
                {
                    var result = MessageBox.Show($@"Do you want to restore: {selectedBook}?", String.Empty, MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;

                    if (!bookManagementCl.RestoreBook(selectedBook.BookId))
                    {
                        MessageBox.Show(@"You cant restore book", String.Empty, MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show(@"You have restore book", String.Empty, MessageBoxButtons.OK);
                }
            }
        }
    }
}