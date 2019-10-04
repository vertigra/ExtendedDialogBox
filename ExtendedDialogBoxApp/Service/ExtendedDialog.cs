using ExtendedDialogBox.PublicDialogBox;
using System.Collections.Generic;

namespace ExtendedDialogBoxApp
{
    /// <summary>
    /// Show dialog window and return dialog result as string
    /// </summary>
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

            string resultString = $"MessageBoxResult.{result} "; 

            return resultString;
        }

        internal string ShowDialog(string dialogButtonType, CustomButtonContent buttonContents, CustomPasswordLabel labels)
        {
            string result = "No result";

            if (dialogButtonType == "Ok")
                result = mDialogBox.OkButton(buttonContents.OkButtonContent).ToString();

            if (dialogButtonType == "OkCancel")
                result = mDialogBox.OkCancelButton(buttonContents.OkButtonContent, buttonContents.CancelButtonContent).ToString();

            if (dialogButtonType == "YesNo")
                result = mDialogBox.YesNoButton(buttonContents.OkButtonContent, buttonContents.NoButtonContent).ToString();

            if (dialogButtonType == "YesNoCancel")
                result = mDialogBox.YesNoCancelButton(buttonContents.OkButtonContent, buttonContents.NoButtonContent, 
                    buttonContents.CancelButtonContent).ToString();

            if (dialogButtonType == "OkYesNoCancel")
                result = mDialogBox.OkYesNoCancelButton(buttonContents.OkButtonContent, buttonContents.YesButtonContent, 
                    buttonContents.NoButtonContent, buttonContents.CancelButtonContent).ToString();

            //mDialogBox.PasswordLabel = labels.PasswordLabel;
            //mDialogBox.PasswordConfirmLabel = labels.PasswordConfirmLabel;

            string resultString = $"MessageBoxResult.{result} ";

            return resultString;
        }
    }

    internal class CustomButtonContent
    {
        internal string OkButtonContent { get; set; }
        internal string CancelButtonContent { get; set; }
        internal string YesButtonContent { get; set; }
        internal string NoButtonContent { get; set; }
    }

    internal class CustomPasswordLabel
    {
        internal string PasswordLabel { get; set; }
        internal string PasswordConfirmLabel { get; set; }
     }
}
