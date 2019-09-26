using ExtendedDialogBox.Command;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class BaseDialogBox
    {
        internal readonly DialogBox mDialogBox;
        internal virtual MessageBoxImage DialogBoxImage { get => MessageBoxImage.None; }

        internal BaseDialogBox()
        {
            mDialogBox = new DialogBox(DialogBoxImage);
            mDialogBox.ButtonCommand = ButtonCommand;
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
                                   mDialogBox.Close();
                                   break;
                               
                               case "No":
                                   Result = MessageBoxResult.No;
                                   mDialogBox.Close();
                                   break;

                               case "Yes":
                                   Result = MessageBoxResult.Yes;
                                   mDialogBox.Close();
                                   break;

                               case "Ok":
                                   Result = MessageBoxResult.OK;
                                   mDialogBox.Close();
                                   break;

                               default:
                                   Result = MessageBoxResult.None;
                                   mDialogBox.Close();
                                   break;
                           }
                       }));
            }
        }

        internal MessageBoxResult Result { get; private set; }

        #endregion

        
        public MessageBoxResult OkButton(string okButtonContent = null)
        {
            if (okButtonContent != null)
                mDialogBox.YesButtonLabel = okButtonContent;

            mDialogBox.OkButtonVisiblity = Visibility.Visible;

            mDialogBox.ShowDialog();

            return Result;
        }


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
    }
}
