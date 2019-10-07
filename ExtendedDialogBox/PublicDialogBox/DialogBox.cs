namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box without an icon
    /// </summary>
    public class DialogBox : BaseDialogBox
    {
        public DialogBox(string message) : base()
        {
            mDialogBox.Message = message;
        }

        public DialogBox(string message, string title) : base()
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
