using System;
using System.Collections.Generic;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class WarningDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Warning;

        public WarningDialogBox(string message)
        {
            mDialogBox.Message = message;
        }

        public WarningDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
