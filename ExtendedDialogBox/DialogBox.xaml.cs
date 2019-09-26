using ExtendedDialogBox.Command;
using ExtendedDialogBox.Utils;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media;
using static ExtendedDialogBox.Utils.IconHeleper;

namespace ExtendedDialogBox
{
    public partial class DialogBox
    {
        internal DialogBox()
        {
            InitializeComponent();

            InitControls();
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            if (MessageImage == MessageBoxImage.None)
                IconHelper.RemoveIcon(this);
        }

        private void InitControls()
        {
            //default all controls collapsed
            CancelButtonVisiblity = Visibility.Collapsed;
            NoButtonVisiblity = Visibility.Collapsed;
            YesButtonVisiblity = Visibility.Collapsed;
            OkButtonVisiblity = Visibility.Collapsed;
            PasswordBoxesVisiblity = Visibility.Collapsed;

            //default content for label
            CancelButtonLabel = "Cancel";
            NoButtonLabel = "No";
            YesButtonLabel = "Yes";
            OkButtonLabel = "OK";

            //default contetnt for password box label
            PasswordLabel = "Пароль";
            PasswordConfirmationLabel = "Подтверждение";
        }

        #region Button Visiblity

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

        #endregion

        #region Button Label

        #region CancelButton Label

        internal string CancelButtonLabel
        {
            get { return (string)GetValue(CancelButtonLabelProperty); }
            set { SetValue(CancelButtonLabelProperty, value); }
        }

        private static readonly DependencyProperty CancelButtonLabelProperty =
            DependencyProperty.Register(nameof(CancelButtonLabel), typeof(string),
                typeof(DialogBox), null);

        #endregion

        #region NoButton Label

        internal string NoButtonLabel
        {
            get { return (string)GetValue(NoButtonLabelProperty); }
            set { SetValue(NoButtonLabelProperty, value); }
        }

        private static readonly DependencyProperty NoButtonLabelProperty =
            DependencyProperty.Register(nameof(NoButtonLabel), typeof(string),
                typeof(DialogBox), null);

        #endregion

        #region YesButton Label

        internal string YesButtonLabel 
        {
            get { return (string) GetValue(YesButtonLabelProperty); }
            set { SetValue(YesButtonLabelProperty, value); }
        }

        private static readonly DependencyProperty YesButtonLabelProperty =
            DependencyProperty.Register(nameof(YesButtonLabel), typeof(string),
                typeof(DialogBox), null);

        #endregion

        #region OkButton Label

        internal string OkButtonLabel
        {
            get { return (string)GetValue(OkButtonLabelProperty); }
            set { SetValue(OkButtonLabelProperty, value); }
        }

        private static readonly DependencyProperty OkButtonLabelProperty =
            DependencyProperty.Register(nameof(OkButtonLabel), typeof(string),
                typeof(DialogBox), null);

        #endregion

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

        #region PasswordBox Label

        # region Password Label

        internal string PasswordLabel
        {
            get { return (string)GetValue(PasswordLabelProperty); }
            set { SetValue(PasswordLabelProperty, value); }
        }

        private static readonly DependencyProperty PasswordLabelProperty =
            DependencyProperty.Register(nameof(PasswordLabel), typeof(string),
                typeof(DialogBox), null);

        #endregion

        # region Password Label

        internal string PasswordConfirmationLabel
        {
            get { return (string)GetValue(PasswordConfirmationLabelProperty); }
            set { SetValue(PasswordConfirmationLabelProperty, value); }
        }

        private static readonly DependencyProperty PasswordConfirmationLabelProperty =
            DependencyProperty.Register(nameof(PasswordConfirmationLabel), typeof(string),
                typeof(DialogBox), null);

        #endregion

        #endregion

        #region DialogBoxTitle

        internal string DialogBoxTitle
        {
            get { return (string)GetValue(DialogBoxTitleProperty); }
            set { SetValue(DialogBoxTitleProperty, value); }
        }

        private static readonly DependencyProperty DialogBoxTitleProperty =
            DependencyProperty.Register(nameof(DialogBoxTitle), typeof(string),
                typeof(DialogBox), null);

        #endregion

        #region DialogBoxMessage

        internal string Message
        {
            get { return (string) GetValue(MessageProperty); }
            set { SetValue (MessageProperty, value); }
        }

        private static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(nameof(Message), typeof(string),
                typeof(DialogBox), null);

        #endregion

        #region DialogBox Image

        #region ImageVisiblity

        internal Visibility ImageVisiblity
        {
            get { return (Visibility)GetValue(ImageVisiblityProperty); }
            set { SetValue(ImageVisiblityProperty, value); }
        }

        private static readonly DependencyProperty ImageVisiblityProperty =
            DependencyProperty.Register(nameof(ImageVisiblity), typeof(Visibility),
                typeof(DialogBox), null);

        #endregion

        #region MessageImage

        private MessageBoxImage messageImage;
        internal MessageBoxImage MessageImage
        {
            get { return messageImage; }
            set
            {  
                messageImage = value;

                DialogBoxIcon = messageImage.ToIcon();
            }
        }

        #endregion

        #region Icon 

        private Icon dialogBoxIcon;
        internal Icon DialogBoxIcon
        {
            get { return dialogBoxIcon; }
            set
            {
                dialogBoxIcon = value;

                if (dialogBoxIcon == null)
                    ImageVisiblity = Visibility.Collapsed;
                
                MessageIcon = dialogBoxIcon.ToImageSource();
                WindowTitleIcon = dialogBoxIcon.ToImageSource();
            }
        }

        #endregion

        #region ImageSource

        private ImageSource MessageIcon
        {
            get { return (ImageSource) GetValue(MessageIconProperty); }
            set { SetValue (MessageIconProperty, value); }
        }

        private static readonly DependencyProperty MessageIconProperty =
            DependencyProperty.Register(nameof(MessageIcon), typeof(ImageSource),
                typeof(DialogBox), null);

        #endregion

        #region TilleIcon 

        private ImageSource WindowTitleIcon
        {
            get { return (ImageSource)GetValue (WindowTitleIconProperty); }
            set { SetValue(WindowTitleIconProperty, value); }
        }

        private static readonly DependencyProperty WindowTitleIconProperty =
            DependencyProperty.Register(nameof(WindowTitleIcon), typeof(ImageSource),
                typeof(DialogBox), null);

        #endregion

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
