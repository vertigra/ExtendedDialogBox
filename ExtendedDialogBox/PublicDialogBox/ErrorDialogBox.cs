using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box with an error icon
    /// </summary>
    public class ErrorDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Error;

        public ErrorDialogBox(string message) : base (message)
        {
            mDialogBox.Title = "Error!";
        }

        public ErrorDialogBox(string message, string title) : base(message, title) {}
    }
}
