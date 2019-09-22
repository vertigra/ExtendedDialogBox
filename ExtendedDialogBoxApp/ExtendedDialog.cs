using ExtendedDialogBox;
using ExtendedDialogBox.PublicDialogBox;
using System.Windows;

namespace ExtendedDialogBoxApp
{
    class ExtendedDialog
    {
        public void ShowQuery()
        {

            QueryDialogBox dialogBox = new QueryDialogBox();

            MessageBoxResult result = dialogBox.YesNoButton();

            /*if (result == MessageBoxResult.Cancel)
                MessageBox.Show("Uieee");*/
        }

    }
}
