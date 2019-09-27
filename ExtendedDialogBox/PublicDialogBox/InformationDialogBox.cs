using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class InformationDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Information;

        public InformationDialogBox(string message)
        {
            mDialogBox.Message = message;
        }

        public InformationDialogBox(string message, string title)
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
