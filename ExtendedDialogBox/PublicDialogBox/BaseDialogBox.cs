using ExtendedDialogBox.Command;
using ExtendedDialogBox.Enum;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Base dialog box methods
    /// </summary>
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

            if (IsPasswordBox || IsPasswordWithConfirm)
            {
                mDialogBox.IsPasswordBoxFocused = true;
            }
                
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

        #region Focused

        private Focused? focused = null;

        /// <summary>
        /// Allows you to set focus on the desired element in the dialog box.
        /// </summary>
        public Focused Focused
        {
            set
            {
                focused = value;
                if (focused == null) return;

                switch (focused)
                {
                    case Focused.CancelButton:
                        mDialogBox.IsCancelFocused = true;
                        break;
                    case Focused.NoButton:
                        mDialogBox.IsNoFocused = true;
                        break;
                    case Focused.OkButton:
                        mDialogBox.IsOkFocused = true;
                        break;
                    case Focused.YesButton:
                        mDialogBox.IsYesFocused = true;
                        break;
                    case Focused.None:
                        mDialogBox.IsFormFocused = true;
                        break;
                }
            }
        }

        #endregion

        #region OkButton
        
        /// <summary>
        /// Shows DialogBox with Ok button
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkButton()
        {
            mDialogBox.OkButtonVisiblity = Visibility.Visible;

            if (focused == null && !IsPasswordBox && !IsPasswordWithConfirm)
                Focused = Focused.OkButton;
            
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
            MessageBoxResult result = OkButton();

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

            if (focused == null && !IsPasswordBox && !IsPasswordWithConfirm)
                Focused = Focused.OkButton;

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

        /// <summary>
        /// Shows DialogBox with Yes and No buttons
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;

            if (focused == null && !IsPasswordBox && !IsPasswordWithConfirm)
                Focused = Focused.YesButton;

            mDialogBox.ShowDialog();

            return Result;
        }

        /// <summary>
        /// Shows DialogBox with Yes and No buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoButton(string yesButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = YesNoButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Yes and No buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <param name="noButtonContent">Text replacing the inscription No on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoButton(string yesButtonContent, string noButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            var result = YesNoButton();

            return result;
        }

        #endregion

        #region YesCancelButton

        /// <summary>
        /// Shows DialogBox with Yes and Cancel buttons
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesCancelButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            if (focused == null && !IsPasswordBox && !IsPasswordWithConfirm)
                Focused = Focused.YesButton;

            mDialogBox.ShowDialog();

            return Result;
        }

        /// <summary>
        /// Shows DialogBox with Yes and Cancel buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesCancelButton(string yesButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = YesCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Yes and Cancel buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <param name="cancelButtonContent">Text replacing the inscription Cancel on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesCancelButton(string yesButtonContent, string cancelButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.CancelButtonLabel = cancelButtonContent;
            var result = YesCancelButton();

            return result;
        }

        #endregion

        #region YesNoCancelButton

        /// <summary>
        /// Shows DialogBox with Yes, No and Cancel buttons
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoCancelButton()
        {
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            if (focused == null && !IsPasswordBox && !IsPasswordWithConfirm)
                Focused = Focused.YesButton;

            mDialogBox.ShowDialog();

            return Result;
        }

        /// <summary>
        /// Shows DialogBox with Yes, No and Cancel buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoCancelButton(string yesButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = YesNoCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Yes, No and Cancel buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <param name="noButtonContent">Text replacing the inscription No on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoCancelButton(string yesButtonContent, string noButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            var result = YesNoCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Yes, No and Cancel buttons
        /// </summary>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <param name="noButtonContent">Text replacing the inscription No on the button</param>
        /// <param name="cancelButtonContent">Text replacing the inscription Cancel on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult YesNoCancelButton(string yesButtonContent, string noButtonContent, string cancelButtonContent)
        {
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            mDialogBox.CancelButtonLabel = cancelButtonContent;
            var result = YesNoCancelButton();

            return result;
        }

        #endregion

        #region OkYesNoCancelButton

        /// <summary>
        /// Shows DialogBox with Ok, Yes, No and Cancel buttons
        /// </summary>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkYesNoCancelButton()
        {
            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            if (focused == null && !IsPasswordBox && !IsPasswordWithConfirm)
                Focused = Focused.OkButton;

            mDialogBox.ShowDialog();

            return Result;
        }

        /// <summary>
        /// Shows DialogBox with Ok, Yes, No and Cancel buttons 
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription Ok on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkYesNoCancelButton(string okButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Ok, Yes, No and Cancel buttons 
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription Ok on the button</param>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkYesNoCancelButton(string okButtonContent, string yesButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            mDialogBox.YesButtonLabel = yesButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Ok, Yes, No and Cancel buttons 
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription Ok on the button</param>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <param name="noButtonContent">Text replacing the inscription No on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
        public MessageBoxResult OkYesNoCancelButton(string okButtonContent, string yesButtonContent, string noButtonContent)
        {
            mDialogBox.OkButtonLabel = okButtonContent;
            mDialogBox.YesButtonLabel = yesButtonContent;
            mDialogBox.NoButtonLabel = noButtonContent;
            var result = OkYesNoCancelButton();

            return result;
        }

        /// <summary>
        /// Shows DialogBox with Ok, Yes, No and Cancel buttons 
        /// </summary>
        /// <param name="okButtonContent">Text replacing the inscription Ok on the button</param>
        /// <param name="yesButtonContent">Text replacing the inscription Yes on the button</param>
        /// <param name="noButtonContent">Text replacing the inscription No on the button</param>
        /// <param name="cancelButtonContent">Text replacing the inscription Cancel on the button</param>
        /// <returns>MessageBoxResult with the result of the pressed button</returns>
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
