using System;
using System.Windows.Forms;
using LibraryApp.ServiceRegister;
using LibraryApp.Utils;

namespace LibraryApp.View
{
    public partial class Register : Form
    {
        private readonly string _path;

        public Register(string path)
        {
            InitializeComponent();
            _path = path;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.SetMinWindow(_path);
            CenterToParent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            using (var registerCl = new ServiceRegisterClient())
            {

                if (registerCl.Check(textBoxUserName.Text, textBoxPassword1.Text, textBoxPassword2.Text))
                {
                    MessageBox.Show(@"U can create account", String.Empty, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(@"U cant create account", String.Empty, MessageBoxButtons.OK);
                }

            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            using (var registerCl = new ServiceRegisterClient())
            {
                if (!(registerCl.Apply(textBoxUserName.Text, textBoxPassword1.Text, textBoxPassword2.Text) is ServiceRegister.User usr))
                {
                    MessageBox.Show(@"U cant create account", String.Empty, MessageBoxButtons.OK);
                    return;
                }

                MessageBox.Show(@"Account Created", String.Empty, MessageBoxButtons.OK);
                Close();
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
