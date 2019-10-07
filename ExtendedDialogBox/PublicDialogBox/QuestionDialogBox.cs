using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box with a question mark icon
    /// </summary>
    public class QuestionDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;

        public QuestionDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Question?";
        }

        public QuestionDialogBox(string message, string title) : base(message, title) { }
    }
}
