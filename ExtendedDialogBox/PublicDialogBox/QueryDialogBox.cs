using ExtendedDialogBox.Command;
using System.ComponentModel;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class QueryDialogBox
    {
        public void YesNoButton()
        {
            DialogBox dialogBox = new DialogBox
            {
                CancelButtonVisiblity = Visibility.Visible
            };

            dialogBox.ButtonCommand = ButtonCommands;

            dialogBox.ShowDialog();
        }

        private RelayCommand buttonCommand;
        public RelayCommand ButtonCommands
        {
            get
            {
                //todo in a separate thread
                return buttonCommand ??
                       (buttonCommand = new RelayCommand(obj =>
                       {

                           string result = obj as string;

                           if(result.Equals("Cancel"))
                               MessageBox.Show("Ueeee");
                          
                       }));
            }
        }


    }
}
