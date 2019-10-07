using System.Security;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class PasswordCofirmDialogBox : DialogBox
    { 
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordWithConfirm => true;

        public PasswordCofirmDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Enter password";
        }

        public PasswordCofirmDialogBox(string message, string title) : base(message, title) { }

        public string PasswordLabel
        {
            get => mDialogBox.PasswordLabel;
            set
            {
                if (value == mDialogBox.PasswordLabel)
                    return;

                mDialogBox.PasswordLabel = value;
            }
        }

        public string PasswordConfirmLabel
        {
            get => mDialogBox.PasswordConfirmationLabel;
            set
            {
                if (value == mDialogBox.PasswordConfirmationLabel)
                    return;

                mDialogBox.PasswordConfirmationLabel = value;
            }
        }

        public SecureString Password { get => mDialogBox.Password; }
        public SecureString PasswordConfirmation { get => mDialogBox.PasswordConfirmation; }

    }
}
