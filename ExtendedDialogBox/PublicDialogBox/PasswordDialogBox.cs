using System.Security;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box with a question mark icon and password fields.
    /// </summary>
    public class PasswordDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordBox => true;

        /// <summary>
        /// Shows a dialog box with a question mark icon and password fields.
        /// </summary>
        /// <param name="message">Text message</param>
        public PasswordDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Enter password";
        }

        /// <summary>
        /// Shows a dialog box with a question mark icon and password fields.
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public PasswordDialogBox(string message, string title) : base (message, title) {}

        /// <summary>
        /// Password confirmation label text
        /// </summary>
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

        /// <summary>
        /// Returns the entered password
        /// </summary>
        public string Password => mDialogBox.Password;

        /// <summary>
        /// Returns the entered password
        /// </summary>
        public SecureString SecurePassword=> mDialogBox.SecurePassword;

        /// <summary>
        /// Clears password entry field
        /// </summary>
        public void ClearPassword() => mDialogBox.ClearPasswordBox();
    }
}
