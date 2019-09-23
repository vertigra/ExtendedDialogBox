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

            dialogBox.YesNoButton();

            /*if (result == MessageBoxResult.Cancel)
                MessageBox.Show("Uieee");*/
        }

    }
}
