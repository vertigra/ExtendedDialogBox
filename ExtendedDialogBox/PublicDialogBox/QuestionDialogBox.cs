using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box with a question mark icon
    /// </summary>
    public class QuestionDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;

        /// <summary>
        /// Shows a dialog box with a question mark icon
        /// </summary>
        /// <param name="message">Text message</param>
        public QuestionDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Question?";
        }

        /// <summary>
        /// Shows a dialog box with a question mark icon
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public QuestionDialogBox(string message, string title) : base(message, title) { }
    }
}
