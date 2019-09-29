using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class PasswordCofirmDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Question;
        internal override bool IsPasswordWithConfirm => true;

        public PasswordCofirmDialogBox(string message)
        {
            mDialogBox.PasswordBoxesGridVisiblity = Visibility.Visible;

            mDialogBox.Message = message;
        }

        public PasswordCofirmDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
