using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class QuestionDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;

        public QuestionDialogBox(string message)
        {
            mDialogBox.Message = message;
        }

        public QuestionDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
