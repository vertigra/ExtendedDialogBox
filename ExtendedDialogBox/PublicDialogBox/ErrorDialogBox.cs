using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class ErrorDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Error;

        public ErrorDialogBox(string message)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = "Error!";
        }

        public ErrorDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }

    }
}
