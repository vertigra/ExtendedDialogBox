using System.Security;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class PasswordDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordBox => true;

        public SecureString Password { get => mDialogBox.Password; } 

        public PasswordDialogBox(string message)
        {
            mDialogBox.Message = message;
        }

        public PasswordDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
