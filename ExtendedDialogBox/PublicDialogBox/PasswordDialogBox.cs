using System.Security;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class PasswordDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordBox => true;

        public PasswordDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Enter password";
        }

        public PasswordDialogBox(string message, string title) : base (message, title) { }

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

        public SecureString Password { get => mDialogBox.Password; }


    }
}
