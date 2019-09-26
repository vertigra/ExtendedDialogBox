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

        public MessageBoxResult YesNoButton(string yesButtonContent = null, string noButtonContent = null)
        {
            if(yesButtonContent != null)
                mDialogBox.YesButtonLabel = yesButtonContent;

            if (noButtonContent != null)
                mDialogBox.NoButtonLabel = noButtonContent;

            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

    }
}
