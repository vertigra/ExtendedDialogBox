using ExtendedDialogBox.PublicDialogBox;
using System.Windows;

namespace ExtendedDialogBoxApp
{
    class ExtendedDialog
    {
        public void ShowQuery()
        {

            QuestionDialogBox dialogBox = new QuestionDialogBox();

            MessageBoxResult result = dialogBox.YesNoButton();

            if (result == MessageBoxResult.Cancel)
                MessageBox.Show("Uieee");
        }

    }
}
