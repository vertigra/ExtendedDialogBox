using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Displays a dialog box with an information icon.
    /// </summary>
    public class InformationDialogBox : DialogBox
    {
        internal override MessageBoxImage DialogBoxImage => MessageBoxImage.Information;

        public InformationDialogBox(string message) : base(message)
        {
            mDialogBox.Title = "Information";
        }

        public InformationDialogBox(string message, string title) : base(message, title) { }
    }
}
