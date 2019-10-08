using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Displays a warning dialog box
    /// </summary>
    public class WarningDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Warning;

        /// <summary>
        /// Displays a warning dialog box
        /// </summary>
        /// <param name="message">Text message</param>
        public WarningDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Warning!";
        }

        /// <summary>
        /// Displays a warning dialog box
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public WarningDialogBox(string message, string title) : base(message, title) { }
    }
}
