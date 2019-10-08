using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Displays a dialog box with an information icon.
    /// </summary>
    public class InformationDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Information;

        /// <summary>
        /// Displays a dialog box with an information icon.
        /// </summary>
        /// <param name="message">Text message</param>
        public InformationDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Information";
        }

        /// <summary>
        /// Displays a dialog box with an information icon.
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public InformationDialogBox(string message, string title) : base(message, title) { }
    }
}
