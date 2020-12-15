using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FISK
{
    /// <summary>
    /// Interaction logic for BottomBar.xaml
    /// </summary>
    public partial class BottomBar : UserControl
    {
        public BottomBar()
        {
            InitializeComponent();
        }

        public void HomeClick(object sender, RoutedEventArgs e)
        {
            /*Kald PageFrame og brug dens navigation til at gå til "LoginPage.xaml"
             som er vores Home.*/
            MainWindow mainWindow = new MainWindow();

            NavigationService nav = mainWindow.PageFrame.NavigationService;            
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            /*Kald på PageFrame og brug dens navigation til at gå et skridt tilbage.
             */
            MainWindow mainWindow = new MainWindow();

            mainWindow.PageFrame.NavigationService.Navigate nav = mainWindow.PageFrame.Navigate(new Uri("LoginPage.xaml", UriKind.RelativeOrAbsolute));

            nav.GoBack();
        }
    }
}
