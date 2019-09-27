using ExtendedDialogBoxApp.ViewModel;
using System.Windows;

namespace ExtendedDialogBoxApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

    }
}
