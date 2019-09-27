using ExtendedDialogBox.PublicDialogBox;

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

            if (dialogButtonType == "OkCancel")
                result = mDialogBox.OkCancelButton().ToString();

            if (dialogButtonType == "YesNo")
                result = mDialogBox.YesNoButton().ToString();

            if (dialogButtonType == "YesNoCancel")
                result = mDialogBox.YesNoCancelButton().ToString();

            if (dialogButtonType == "OkYesNoCancel")
                result = mDialogBox.OkYesNoCancelButton().ToString();

            string resultString = $"Return MessageBoxResult.{result} "; 

            return resultString;
        }

    }
}
