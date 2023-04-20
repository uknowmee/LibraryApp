using System;
using System.Windows.Forms;
using LibraryApp.ServiceBooksView;
using LibraryApp.ServiceLogin;
using LibraryApp.ServiceNotifications;
using UsableBook = LibraryApp.ServiceNotifications.UsableBook;

namespace LibraryApp.Controller.User
{
    // Todo:
    // Parent class of Admin, and User
    public class UsableUser
    {
        public ServiceLogin.User User;

        public UsableUser(ServiceLogin.User user)
        {
            User = user;
        }

        public static UsableUser TryLoginUser(ServiceLogin.User respUser, UsableUser usableUser)
        {
            if (respUser == null) return null;

            if (usableUser != null) return usableUser;

            using (var loginCl = new ServiceLoginClient())
            {
                if (loginCl.IsUserAdmin(respUser.UserId))
                {
                    usableUser = new Admin(respUser);
                }
                else
                {
                    usableUser = new StdUser(respUser);

                    using (var serviceNf = new ServiceNotificationsClient())
                    {
                        foreach (UsableBook usableBook in serviceNf.TimeIsEnding(((StdUser)usableUser).User.UserId))
                        {
                            MessageBox.Show($@"Time of rent is ending!{usableBook.Title}", String.Empty);
                        }
                    }
                }
                
                return usableUser;
            }
        }
    }
}