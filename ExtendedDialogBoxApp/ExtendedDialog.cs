using ExtendedDialogBox.PublicDialogBox;
using System.Windows;

namespace ExtendedDialogBoxApp
{
    class ExtendedDialog
    {
        private readonly DialogBox mDialogBox;
        internal ExtendedDialog(DialogBox DialogBox)
        {
            mDialogBox = DialogBox;
        }

        internal string ShowDialog(string dialogButtonType)
        {
            string result = "No result";

            if (dialogButtonType == "Ok")
                result = mDialogBox.OkButton().ToString();

            

            return result;
        }

    }
}
