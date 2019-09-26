using ExtendedDialogBox.Command;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class BaseDialogBox
    {
        internal readonly DialogBox mDialogBox;
        internal virtual MessageBoxImage DialogBoxImage { get => MessageBoxImage.None; }

        public BaseDialogBox()
        {
            mDialogBox = new DialogBox(DialogBoxImage);
        }

        private RelayCommand buttonCommand;
        internal RelayCommand ButtonCommands
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

        internal MessageBoxResult Result { get; set; }
    }
}
