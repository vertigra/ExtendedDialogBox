using ExtendedDialogBoxApp.ViewModel;
using System.Windows;

namespace ExtendedDialogBoxApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

    }


}
