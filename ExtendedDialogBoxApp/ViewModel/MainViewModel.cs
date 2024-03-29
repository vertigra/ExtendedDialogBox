﻿using ExtendedDialogBox.PublicDialogBox;
using ExtendedDialogBoxApp.Utils;
using ExtendedDialogBoxAppCommand;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ExtendedDialogBoxApp.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private RelayCommand showDialogBox;
        private string DialogButtonType { get; set; } = "Ok";
        private string DialogType { get; set; } = "NoIcons";
        private string Focused { get; set; } = "Default";

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
                               MessageBox.Show("Not defined dialog type");

                           ExtendedDialog dialog = new ExtendedDialog(dialogType, Focused);
                           string result = null;

                           if (IsCustomContentUse)
                           {
                               CustomButtonContent contents = new CustomButtonContent
                               {
                                   OkButtonContent = OkButtonContent,
                                   CancelButtonContent = CancelButtonContent,
                                   NoButtonContent = NoButtonContent,
                                   YesButtonContent = YesButtonContent,                                   
                               };

                               CustomPasswordLabel labels = new CustomPasswordLabel
                               {
                                   PasswordLabel = PasswordLabel,
                                   PasswordConfirmLabel = PasswordConfirmLabel
                               };
                               
                               
                               dialog = new ExtendedDialog(dialogType, Focused);
                               result = dialog.ShowDialog(DialogButtonType, contents, labels);
                           }
                           else
                               result = dialog.ShowDialog(DialogButtonType);

                           if (result == null)
                               MessageBox.Show("No result exception");

                           
                           ResultsTextBlockAdd("ButtonResult return", result);

                           if (dialogType is PasswordDialogBox passwordDialog)
                           {
                               ResultsTextBlockAdd("Password.ToUnsecureString()\nreturn",
                               passwordDialog.SecurePassword.ToUnsecureString());
                           }

                           if (dialogType is PasswordCofirmDialogBox passwordCofirmDialog)
                           {
                               ResultsTextBlockAdd("Password.ToUnsecureString()\nreturn",
                                   passwordCofirmDialog.SecurePassword.ToUnsecureString());

                               ResultsTextBlockAdd("PasswordConfirmation.ToUnsecureString()\nreturn",
                                   passwordCofirmDialog.SecurePasswordConfirmation.ToUnsecureString());
                           }
                       }));
            }
        }

        #region TextUtils

        private void ResultsTextBlockAdd(string title, string message)
        {
            if (ResultTextBlock.Length == 0)
                ResultTextBlock = $"{title}:\n{message}";
            else
                ResultTextBlock += $"\n{title}:\n{message}";
        }

        #endregion

        #region Command
        
        public RelayCommand NoIconsRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = "Ok";

            if (obj != null)
                param = obj as string;

            DialogButtonType = param;
            DialogType = "NoIcons";
        });

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

        public RelayCommand ErrorRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = obj as string;

            DialogButtonType = param;
            DialogType = "Error";
        });

        public RelayCommand PasswordRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = obj as string;

            DialogButtonType = param;
            DialogType = "Password";
        });

        public RelayCommand PasswordConfirmRadioButtonCommand => new RelayCommand(obj =>
        {
            ResultTextBlock = "";

            string param = obj as string;

            DialogButtonType = param;
            DialogType = "PasswordConfirm";
        });

        public RelayCommand SetFocusOn => new RelayCommand(obj =>
        {
            string param = obj as string;

            Focused = param;
            
        });

       
        #endregion

        #region SelectDialogType

        private DialogBox GetDialogType()
        {
            if (DialogType.Equals("NoIcons"))
                return new DialogBox("Any text message", "Title");
            
            if (DialogType.Equals("Question"))
                return new QuestionDialogBox("Question?") { };

            if (DialogType.Equals("Warning"))
                return new WarningDialogBox("Warning!") { };

            if (DialogType.Equals("Information"))
                return new InformationDialogBox("Information") { };

            if (DialogType.Equals("Error"))
                return new ErrorDialogBox("Error") { };

            if (DialogType.Equals("Password"))
                return new PasswordDialogBox("Enter password") { };

            if (DialogType.Equals("PasswordConfirm"))
                return new PasswordCofirmDialogBox("Enter password") { };

            return null;
        }

        #endregion

        #region Binding

        #region CustomButtonContent

        private string okButtonContent = "CustomOk";
        public string OkButtonContent
        {
            get { return okButtonContent; }
            set
            {
                if (value.Equals(okButtonContent))
                    return;

                okButtonContent = value;
                OnPropertyChanged(nameof(OkButtonContent));
            }
        }

        private string cancelButtonContent = "CustomCancel";
        public string CancelButtonContent
        {
            get { return cancelButtonContent; }
            set
            {
                if (value.Equals(cancelButtonContent))
                    return;

                cancelButtonContent = value;
                OnPropertyChanged(nameof(CancelButtonContent));
            }
        }

        private string yesButtonContent = "CustomYes";
        public string YesButtonContent
        {
            get { return yesButtonContent; }
            set
            {
                if (value.Equals(yesButtonContent))
                    return;

                yesButtonContent = value;
                OnPropertyChanged(nameof(YesButtonContent));
            }
        }

        private string noButtonContent = "CustomNo";
        public string NoButtonContent
        {
            get { return noButtonContent; }
            set
            {
                if (value.Equals(noButtonContent))
                    return;

                noButtonContent = value;
                OnPropertyChanged(nameof(NoButtonContent));
            }
        }

        #endregion

        #region CustomLabel

        private string passwordLabel = "CustomPasswordLabel";
        public string PasswordLabel
        {
            get { return passwordLabel; }
            set
            {
                if (value.Equals(passwordLabel))
                    return;

                passwordLabel = value;
                OnPropertyChanged(nameof(PasswordLabel));
            }
        }

        private string passwordConfirmLabel = "CustomConfirmLabel";
        public string PasswordConfirmLabel
        {
            get { return passwordConfirmLabel; }
            set
            {
                if (value.Equals(passwordConfirmLabel))
                    return;

                passwordConfirmLabel = value;
                OnPropertyChanged(nameof(PasswordConfirmLabel));
            }
        }

        #endregion

        private string resultTextBlock = "";
        public string ResultTextBlock
        {
            get { return resultTextBlock; }
            set
            {
                if (value.Equals(resultTextBlock))
                    return;

                resultTextBlock = value;
                OnPropertyChanged(nameof(ResultTextBlock));
            }
        }

        private bool isCustomContentUse;
        public bool IsCustomContentUse
        {
            get { return isCustomContentUse; }
            set
            {
                if (value == isCustomContentUse)
                    return;

                isCustomContentUse = value;
                OnPropertyChanged(nameof(IsCustomContentUse));
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


