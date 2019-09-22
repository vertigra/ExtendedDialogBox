using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class QueryDialogBox
    {
        public MessageBoxResult YesNoButton()
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.CancelButtonVisiblity = Visibility.Visible;
            dialogBox.ShowDialog();

            return dialogBox.Result;
        }
    }
}
