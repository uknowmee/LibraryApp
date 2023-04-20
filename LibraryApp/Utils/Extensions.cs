using System.Drawing;
using System.Windows.Forms;

namespace LibraryApp.Utils
{
    public static class Extensions
    {
        public static void SetMinWindow(this Form myForm, string path)
        {
            if (myForm.WindowState != FormWindowState.Normal)
            {
                myForm.WindowState = FormWindowState.Normal;
            }

            myForm.BackgroundImageLayout = ImageLayout.Stretch;
            myForm.BackgroundImage = Image.FromFile(path);
        }

        public static void SetMaxWindow(this Form myForm, string path)
        {
            if (myForm.WindowState != FormWindowState.Maximized)
            {
                myForm.WindowState = FormWindowState.Maximized;
            }

            myForm.BackgroundImageLayout = ImageLayout.Stretch;
            myForm.BackgroundImage = Image.FromFile(path);
        }
    }
}