using System.Security;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class PasswordCofirmDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordWithConfirm => true;

        public SecureString Password { get => mDialogBox.Password; }
        public SecureString PasswordConfirmation { get => mDialogBox.PasswordConfirmation; }

        public PasswordCofirmDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Enter password";
        }

        public PasswordCofirmDialogBox(string message, string title) : base(message, title) { }
    }
}
