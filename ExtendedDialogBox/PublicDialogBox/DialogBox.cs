using ExtendedDialogBox.Command;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class DialogBox
    {
        internal ExtendedDialogBox.DialogBox mDialogBox;
        internal virtual MessageBoxImage DialogBoxImage { get => MessageBoxImage.None; }
        internal virtual bool IsPasswordBox { get => false; }
        internal virtual bool IsPasswordWithConfirm { get => false; }

        internal DialogBox()
        {
            mDialogBox = new ExtendedDialogBox.DialogBox(DialogBoxImage)
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

        public MessageBoxResult OkButton(string okButtonContent = null)
        {
            if (okButtonContent != null)
                mDialogBox.YesButtonLabel = okButtonContent;

            mDialogBox.OkButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

        #endregion

        #region OkCancelButton

        public MessageBoxResult OkCancelButton(string okButtonContent = null, string cancelButtonContent = null)
        {
            if (okButtonContent != null)
                mDialogBox.OkButtonLabel = okButtonContent;

            if (cancelButtonContent != null)
                mDialogBox.OkButtonLabel = cancelButtonContent;

            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

        #endregion

        #region YesNoButton

        public MessageBoxResult YesNoButton(string yesButtonContent = null, string noButtonContent = null)
        {
            if (yesButtonContent != null)
                mDialogBox.YesButtonLabel = yesButtonContent;

            if (noButtonContent != null)
                mDialogBox.NoButtonLabel = noButtonContent;

            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

        #endregion

        #region YesCancelButton

        public MessageBoxResult YesCancelButton(string yesButtonContent = null, string cancelButtonContent = null)
        {
            if (yesButtonContent != null)
                mDialogBox.YesButtonLabel = yesButtonContent;

            if (cancelButtonContent != null)
                mDialogBox.CancelButtonLabel = cancelButtonContent;

            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

        #endregion

        #region YesNoCancelButton

        public MessageBoxResult YesNoCancelButton(string yesButtonContent = null,
            string noButtonContent = null, string cancelButtonContent = null)
        {
            if (yesButtonContent != null)
                mDialogBox.YesButtonLabel = yesButtonContent;

            if (noButtonContent != null)
                mDialogBox.YesButtonLabel = noButtonContent;

            if (cancelButtonContent != null)
                mDialogBox.CancelButtonLabel = cancelButtonContent;

            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

        #endregion

        #region OkYesNoCancelButton

        public MessageBoxResult OkYesNoCancelButton(string okButtonContent = null, 
            string yesButtonContent = null, string noButtonContent = null, 
            string cancelButtonContent = null)
        {

            if (okButtonContent != null)
                mDialogBox.OkButtonLabel = okButtonContent;

            if (yesButtonContent != null)
                mDialogBox.YesButtonLabel = yesButtonContent;

            if (noButtonContent != null)
                mDialogBox.YesButtonLabel = noButtonContent;

            if (cancelButtonContent != null)
                mDialogBox.CancelButtonLabel = cancelButtonContent;

            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }

        #endregion
    }


}
