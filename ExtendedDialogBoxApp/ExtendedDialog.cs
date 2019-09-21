using ExtendedDialogBox;

namespace ExtendedDialogBoxApp
{
    class ExtendedDialog
    {
        public void ShowQuery()
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.CancelButtonVisiblity = System.Windows.Visibility.Visible;

            dialogBox.Show();
        }

    }
}
