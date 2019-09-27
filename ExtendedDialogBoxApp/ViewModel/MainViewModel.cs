using ExtendedDialogBox.PublicDialogBox;
using ExtendedDialogBoxAppCommand;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExtendedDialogBoxApp.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private RelayCommand showDialogBox;
        private string DialogButtonType { get; set; } = "Ok";
        private string DialogType { get; set; } = "Question";

        public RelayCommand ShowDialogBox
        {
            get
            {
                return showDialogBox ??
                       (showDialogBox = new RelayCommand(obj =>
                       {
                           ResultTextBlock = "";

                           var dialogType = GetDialogType();

                           if (dialogType == null)
                               throw new Exception("Not defined dialog type");

                           ExtendedDialog dialog = new ExtendedDialog(dialogType);
                           var result = dialog.ShowDialog(DialogButtonType);

                           if (result == null) throw new Exception("No result exception");

                           if(IsResultShow)
                                ResultTextBlock = result;
                       }));
            }
        }

        #region Command
        
        public RelayCommand QuestionRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = "Ok";
            
            if(obj != null)
                param = obj as string;

            DialogButtonType = param;
            DialogType = "Question";
        });

        public RelayCommand WarningRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = obj as string;

            DialogButtonType = param;
            DialogType = "Warning";
        });

        public RelayCommand InformationRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = obj as string;

            DialogButtonType = param;
            DialogType = "Information";
        });


        #endregion

        private DialogBox GetDialogType()
        {
            if(DialogType.Equals("Question"))
                return new QuestionDialogBox("Question?", "Question?");

            if (DialogType.Equals("Warning"))
                return new WarningDialogBox("Warning!", "Warning!");

            if (DialogType.Equals("Information"))
                return new InformationDialogBox("Information", "Information");

            return null;
        }

        #region Binding

        private string resultTextBlock = "";
        public string ResultTextBlock
        {
            get { return resultTextBlock; }
            set
            {
                if (value.Equals(resultTextBlock)) return;

                resultTextBlock = value;
                OnPropertyChanged(nameof(ResultTextBlock));
            }
        }

        private bool isResultShow = true;
        public bool IsResultShow
        {
            get { return isResultShow; }
            set
            {
                if (value == isResultShow) return;
                isResultShow = value;

                OnPropertyChanged(nameof(IsResultShow));
            }
        }

        #endregion

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}


