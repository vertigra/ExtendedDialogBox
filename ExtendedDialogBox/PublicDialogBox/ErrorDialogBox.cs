using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box with an error icon
    /// </summary>
    public class ErrorDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Error;

        /// <summary>
        /// Shows a dialog box with an error icon
        /// </summary>
        /// <param name="message">Text message</param>
        public ErrorDialogBox(string message) : base (message)
        {
            mDialogBox.Title = "Error!";
        }

        /// <summary>
        /// Shows a dialog box with an error icon
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public ErrorDialogBox(string message, string title) : base (message, title) {}
    }
}
