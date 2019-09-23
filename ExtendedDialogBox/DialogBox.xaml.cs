using ExtendedDialogBox.Command;
using System.Windows;
namespace ExtendedDialogBox
{
    public partial class DialogBox
    {
        internal DialogBox()
        {
            InitializeComponent();

            //by default all controls collapsed
            CancelButtonVisiblity = Visibility.Collapsed;
            NoButtonVisiblity = Visibility.Collapsed;
            YesButtonVisiblity = Visibility.Collapsed;
            OkButtonVisiblity = Visibility.Collapsed;
            PasswordBoxesVisiblity = Visibility.Collapsed;
        }

        #region CancelButton Visiblity

        internal Visibility CancelButtonVisiblity
        {
            get { return (Visibility) GetValue(CancelButtonVisiblityProperty); }
            set { SetValue(CancelButtonVisiblityProperty, value); }
        }

        private static readonly DependencyProperty CancelButtonVisiblityProperty =
            DependencyProperty.Register(nameof(CancelButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);

        #endregion

        #region NoButton Visiblity

        internal Visibility NoButtonVisiblity
        {
            get { return (Visibility) GetValue(NoButtonVisiblityProperty); }
            set { SetValue(NoButtonVisiblityProperty, value); }
        }

        private static readonly DependencyProperty NoButtonVisiblityProperty =
            DependencyProperty.Register(nameof(NoButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);


        #endregion

        #region YesButton Visiblity

        internal Visibility YesButtonVisiblity
        {
            get { return (Visibility)GetValue(YesButtonVisiblityProperty); }
            set { SetValue(YesButtonVisiblityProperty, value); }
        }

        private static readonly DependencyProperty YesButtonVisiblityProperty =
            DependencyProperty.Register(nameof(YesButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);


        #endregion

        #region OkButton Visiblity

        internal Visibility OkButtonVisiblity
        {
            get { return (Visibility)GetValue(OkButtonVisiblityProperty); }
            set { SetValue(OkButtonVisiblityProperty, value); }
        }

        private static readonly DependencyProperty OkButtonVisiblityProperty =
            DependencyProperty.Register(nameof(OkButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);

        #endregion

        #region PasswordBoxes Visiblity

        internal Visibility PasswordBoxesVisiblity
        {
            get { return (Visibility)GetValue(PasswordBoxesProperty); }
            set { SetValue(PasswordBoxesProperty, value); }
        }

        private static readonly DependencyProperty PasswordBoxesProperty =
            DependencyProperty.Register(nameof(PasswordBoxesVisiblity), typeof(Visibility),
                typeof(DialogBox), null);

        #endregion

        #region Button RelayCommand

        internal RelayCommand ButtonCommand
        {
            get { return (RelayCommand)GetValue(CancelButtonCommandProperty); }
            set { SetValue(CancelButtonCommandProperty, value); }
        }


        private static readonly DependencyProperty CancelButtonCommandProperty =
            DependencyProperty.Register(nameof(ButtonCommand), typeof(RelayCommand),
                typeof(DialogBox), null);

        #endregion
    }
}
