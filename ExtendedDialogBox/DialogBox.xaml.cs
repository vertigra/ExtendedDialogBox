using ExtendedDialogBox.Command;
using System.Windows;
namespace ExtendedDialogBox
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class DialogBox
    {
        internal DialogBox()
        {
            InitializeComponent();
        }

        #region CancelButton

        internal Visibility CancelButtonVisiblity
        {
            get { return (Visibility)GetValue(CancelButtonVisiblityProperty); }
            set { SetValue(CancelButtonVisiblityProperty, value); }
        }

        private static readonly DependencyProperty CancelButtonVisiblityProperty =
            DependencyProperty.Register(nameof(CancelButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);

      
        internal RelayCommand ButtonCommand
        {
            get { return (RelayCommand) GetValue(CancelButtonCommandProperty); }
            set { SetValue(CancelButtonCommandProperty, value); }
        }
        
        
        private static readonly DependencyProperty CancelButtonCommandProperty =
            DependencyProperty.Register(nameof(ButtonCommand), typeof(RelayCommand),
                typeof(DialogBox), null);

        

        #endregion

        #region NoButton

        internal Visibility NoButtonVisiblity
        {
            get { return (Visibility)GetValue(NoButtonProperty); }
            set { SetValue(NoButtonProperty, value); }
        }

        private static readonly DependencyProperty NoButtonProperty =
            DependencyProperty.Register(nameof(NoButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);


        internal RelayCommand NoButtonCommand
        {
            get { return (RelayCommand)GetValue(NoButtonCommandProperty); }
            set { SetValue(NoButtonCommandProperty, value); }
        }

        private static readonly DependencyProperty NoButtonCommandProperty =
            DependencyProperty.Register(nameof(NoButtonCommand), typeof(RelayCommand),
                typeof(DialogBox), null);

        #endregion

        #region YesButton

        internal Visibility YesButtonVisiblity
        {
            get { return (Visibility)GetValue(YesButtonProperty); }
            set { SetValue(YesButtonProperty, value); }
        }

        private static readonly DependencyProperty YesButtonProperty =
            DependencyProperty.Register(nameof(YesButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);


        internal RelayCommand YesButtonCommand
        {
            get { return (RelayCommand)GetValue(YesButtonCommandProperty); }
            set { SetValue(YesButtonCommandProperty, value); }
        }

        private static readonly DependencyProperty YesButtonCommandProperty =
            DependencyProperty.Register(nameof(YesButtonCommand), typeof(RelayCommand),
                typeof(DialogBox), null);

        #endregion

        #region OkButton

        internal Visibility OkButtonVisiblity
        {
            get { return (Visibility)GetValue(OkButtonProperty); }
            set { SetValue(OkButtonProperty, value); }
        }

        private static readonly DependencyProperty OkButtonProperty =
            DependencyProperty.Register(nameof(OkButtonVisiblity), typeof(Visibility),
                typeof(DialogBox), null);


        internal RelayCommand OkButtonCommand
        {
            get { return (RelayCommand)GetValue(OkButtonCommandProperty); }
            set { SetValue(OkButtonCommandProperty, value); }
        }

        private static readonly DependencyProperty OkButtonCommandProperty =
            DependencyProperty.Register(nameof(OkButtonCommand), typeof(RelayCommand),
                typeof(DialogBox), null);

        #endregion


    }
}
