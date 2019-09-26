using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class QuestionDialogBox : BaseDialogBox
    {
        public QuestionDialogBox()
        {
            //set as base parametr
            mDialogBox.MessageImage = MessageBoxImage.Question;

            mDialogBox.Message = "Question";
            mDialogBox.Title = "Question?";
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
