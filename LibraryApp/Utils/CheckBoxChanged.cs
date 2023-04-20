using System.Windows.Forms;

namespace LibraryApp.Utils
{
    public static class CheckBoxChanged
    {
        public static CheckBox CheckPreviousState(bool dontChange, CheckBox checkBox)
        {
            if (dontChange) return checkBox;

            checkBox.Checked = !checkBox.Checked;

            return checkBox;
        }
    }
}