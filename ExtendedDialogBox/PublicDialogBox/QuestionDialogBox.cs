using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class QuestionDialogBox : BaseDialogBox
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

        public MessageBoxResult YesNoButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            
            mDialogBox.ShowDialog();

            return Result;
        }

    }
}
