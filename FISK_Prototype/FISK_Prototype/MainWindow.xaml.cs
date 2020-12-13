using FISK_Prototype.ViewModel.Controls;
using System.Windows;

namespace FISK_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mwvm = new MainWindowViewModel();
            DataContext = mwvm;
        }

    }
}
