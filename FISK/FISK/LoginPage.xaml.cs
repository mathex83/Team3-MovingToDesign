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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            LoginSubPage1 loginSubPage1 = new LoginSubPage1();
            this.Visibility = Visibility.Hidden;
            MainWindow mainWindow1 = new MainWindow();
            loginSubPage1.Visibility = Visibility.Visible;
            mainWindow1.myFrame.Navigate(loginSubPage1);
        }
    }
}
