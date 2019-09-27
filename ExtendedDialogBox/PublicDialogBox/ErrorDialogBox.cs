using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    class ErrorDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Error;

        public ErrorDialogBox(string message)
        {
            mDialogBox.Message = message;
        }

        public ErrorDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }

    }
}
