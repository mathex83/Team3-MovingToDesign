using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("LoginSubPage1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AddUserClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("LoginSubPage2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
