using ExtendedDialogBoxAppCommand;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExtendedDialogBoxApp.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private RelayCommand showDialogBox;
        public RelayCommand ShowDialogBox
        {
            get
            {
                return showDialogBox ??
                       (showDialogBox = new RelayCommand(obj =>
                       {
                           ExtendedDialog dialog = new ExtendedDialog();
                           dialog.ShowQuery();
                       }));
            }
        }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
