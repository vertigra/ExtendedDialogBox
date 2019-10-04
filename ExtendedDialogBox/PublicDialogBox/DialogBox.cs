namespace ExtendedDialogBox.PublicDialogBox
{
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
