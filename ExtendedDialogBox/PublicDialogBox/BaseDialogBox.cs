﻿using ExtendedDialogBox.Command;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class BaseDialogBox
    {
        internal virtual MessageBoxImage DialogBoxImage { get => MessageBoxImage.None; }
        internal virtual bool IsPasswordBox { get => false; }
        internal virtual bool IsPasswordWithConfirm { get => false; }

        internal DialogBoxWindow mDialogBox;

        private protected BaseDialogBox()
        {
            mDialogBox = new DialogBoxWindow(DialogBoxImage)
            {
                ButtonCommand = ButtonCommand
            };

            if (IsPasswordBox)
            {
                mDialogBox.PasswordBoxesGridVisiblity = Visibility.Visible;
                mDialogBox.PasswordConfirmationInputBoxVisiblitiy = Visibility.Collapsed;
            }

            if (IsPasswordWithConfirm)
                mDialogBox.PasswordBoxesGridVisiblity = Visibility.Visible;
        }

        #region Command

        private RelayCommand buttonCommand;
        private RelayCommand ButtonCommand
        {
            get
            {
                return buttonCommand ??
                       (buttonCommand = new RelayCommand(obj =>
                       {
                           string result = (string)obj;

                           switch (result)
                           {
                               case "Cancel":
                                   Result = MessageBoxResult.Cancel;
                                   break;
                               case "No":
                                   Result = MessageBoxResult.No;
                                   break;
                               case "Yes":
                                   Result = MessageBoxResult.Yes;
                                   break;
                               case "Ok":
                                   Result = MessageBoxResult.OK;
                                   break;

                               default:
                                   Result = MessageBoxResult.None;
                                   break;
                           }

                           mDialogBox.Close();
                       }));

            }
        }

        internal MessageBoxResult Result { get; private set; }

        #endregion

        #region OkButton

        /// <summary>
        /// Shows DialogBox with Ok button
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkButton()
        {
            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.ShowDialog();

            return Result;
        }

        /// <summary>
        /// Shows DialogBox with Ok button
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription OK on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkButton(string okButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            var result = OkButton();

            return result;
        }

        #endregion

        #region OkCancelButton

        /// <summary>
        /// Shows DialogBox with Ok and Cancel buttons
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkCancelButton()
        {
            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;
            mDialogBox.ShowDialog();

            return Result;
        }

        /// <summary>
        /// Shows DialogBox with Ok and Cancel buttons
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription OK on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkCancelButton(string okButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            var result = OkCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Ok and Cancel buttons
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription OK on the button</param>
        /// <param name="cancelButtonContent">Text replacing the inscription Cancel on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkCancelButton(string okButtonContent, string cancelButtonContent)
        {

            mDialogBox.OkButtonLabel = okButtonContent;
            mDialogBox.CancelButtonLabel = cancelButtonContent;
            var result = OkCancelButton();

            return result;
        }

        #endregion

        #region YesNoButton
    
        public MessageBoxResult YesNoButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.ShowDialog();

            return Result;
        }

        public MessageBoxResult YesNoButton(string yesButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = YesNoButton();

            return result;
        }


        public MessageBoxResult YesNoButton(string yesButtonContent, string noButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            var result = YesNoButton();

            return result;
        }

        #endregion

        #region YesCancelButton

        public MessageBoxResult YesCancelButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;
            mDialogBox.ShowDialog();

            return Result;
        }

        public MessageBoxResult YesCancelButton(string yesButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = YesCancelButton();

            return result;
        }


        public MessageBoxResult YesCancelButton(string yesButtonContent, string cancelButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.CancelButtonLabel = cancelButtonContent;
            var result = YesCancelButton();

            return result;
        }

        #endregion

        #region YesNoCancelButton

        public MessageBoxResult YesNoCancelButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;
            mDialogBox.ShowDialog();

            return Result;
        }

        public MessageBoxResult YesNoCancelButton(string yesButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = YesCancelButton();

            return result;
        }

        public MessageBoxResult YesNoCancelButton(string yesButtonContent, string noButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            var result = YesCancelButton();

            return result;
        }

        public MessageBoxResult YesNoCancelButton(string yesButtonContent, string noButtonContent, string cancelButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            mDialogBox.CancelButtonLabel = cancelButtonContent;
            var result = YesCancelButton();

            return result;
        }

        #endregion

        #region OkYesNoCancelButton

        public MessageBoxResult OkYesNoCancelButton()
        {
            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;
            mDialogBox.ShowDialog();

            return Result;
        }

        public MessageBoxResult OkYesNoCancelButton(string okButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        public MessageBoxResult OkYesNoCancelButton(string okButtonContent, string yesButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        public MessageBoxResult OkYesNoCancelButton(string okButtonContent, string yesButtonContent, string noButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        public MessageBoxResult OkYesNoCancelButton(string okButtonContent, string yesButtonContent, string noButtonContent, string cancelButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;        
            mDialogBox.CancelButtonLabel = cancelButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        #endregion

    }
}