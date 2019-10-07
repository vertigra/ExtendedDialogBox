using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class WarningDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Warning;

        public WarningDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Warning!";
        }

        public WarningDialogBox(string message, string title) : base(message, title) { }
    }
}
