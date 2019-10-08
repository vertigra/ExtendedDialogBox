using System.Security;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box with a question mark icon and fields for entering a password and re-entering a password
    /// </summary>
    public class PasswordCofirmDialogBox : DialogBox
    { 
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordWithConfirm => true;

        /// <summary>
        /// Shows a dialog box with a question mark icon and fields for entering a password and re-entering a password
        /// </summary>
        /// <param name="message">Text message</param>
        public PasswordCofirmDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Enter password";
        }

        /// <summary>
        /// Shows a dialog box with a question mark icon and fields for entering a password and re-entering a password
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public PasswordCofirmDialogBox(string message, string title) : base(message, title) { }

        /// <summary>
        /// Password label text
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
        /// Password confirmation label text
        /// </summary>
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

        /// <summary>
        /// Returns the entered password
        /// </summary>
        public string Password => mDialogBox.Password;

        /// <summary>
        /// Returns the entered password confirmation
        /// </summary>
        public string PasswordConfirmation => mDialogBox.PasswordConfirmation;

        /// <summary>
        /// Returns the entered password
        /// </summary>
        public SecureString SecurePassword => mDialogBox.SecurePassword;

        /// <summary>
        /// Returns the entered password confirmation
        /// </summary>
        public SecureString SecurePasswordConfirmation => mDialogBox.SecurePasswordConfirmation;

        /// <summary>
        /// Clears password entry field
        /// </summary>
        public void ClearPassword() => mDialogBox.ClearPasswordBox();

        /// <summary>
        /// Clears password confirmation entry field
        /// </summary>
        public void ClearPasswordConfirmation() => mDialogBox.ClearPasswordConfirmationBox();
    }
}
