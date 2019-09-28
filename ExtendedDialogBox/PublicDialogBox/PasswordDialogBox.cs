﻿using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class PasswordDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordBox => true;

        private PasswordDialogBox()
        {
            
        }

        public PasswordDialogBox(string message)
        {
            mDialogBox.PasswordBoxesGridVisiblity = Visibility.Visible;

            mDialogBox.Message = message;
        }

        public PasswordDialogBox(string message, string title)
        {
            mDialogBox.PasswordBoxesGridVisiblity = Visibility.Visible;
            mDialogBox.PasswordConfirmationInputBoxVisiblitiy = Visibility.Collapsed;

            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
