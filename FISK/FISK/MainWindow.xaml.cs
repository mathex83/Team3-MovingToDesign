using System.Windows;

namespace FISK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage();
            PageFrame.NavigationService.Navigate(loginPage);
        }
    }
}
