using System;
using System.Windows.Forms;
using LibraryApp.ServiceLogin;
using LibraryApp.Utils;

namespace LibraryApp.View
{
    // Todo:
    // login + pass
    public partial class Login : Form
    {
        private readonly string _path;
        public ServiceLogin.User User;
        public bool Quited;

        public Login(string path)
        {
            _path = path;
            User = null;
            Quited = false;

            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Quited = true;
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var loginCl = new ServiceLoginClient())
            {
                if (!(loginCl.Login(textBoxUserName.Text, textBoxPassword.Text) is ServiceLogin.User user))
                {
                    MessageBox.Show(@"Invalid credentials", String.Empty, MessageBoxButtons.OK);
                    return;
                }

                User = user;

                Close();
            }
        }
    }
}
