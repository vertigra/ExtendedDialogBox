namespace ExtendedDialogBox.PublicDialogBox
{
    /// <summary>
    /// Shows a dialog box without an icon
    /// </summary>
    public class DialogBox : BaseDialogBox
    {
        /// <summary>
        /// Shows a dialog box without an icon
        /// </summary>
        /// <param name="message">Text message</param>
        public DialogBox(string message) : base()
        {
            mDialogBox.Message = message;
        }

        /// <summary>
        /// Shows a dialog box without an icon
        /// </summary>
        /// <param name="message">Text message</param>
        /// <param name="title">Text title</param>
        public DialogBox(string message, string title) : base()
        {
            mDialogBox.Message = message;
            mDialogBox.Title = title;
        }
    }
}
