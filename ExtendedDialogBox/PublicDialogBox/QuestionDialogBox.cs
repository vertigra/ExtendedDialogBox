using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
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
