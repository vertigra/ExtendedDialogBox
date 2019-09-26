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
    }
}
