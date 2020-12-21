using System;
using System.Windows;
using System.Windows.Controls;

namespace FISK
{
    /// <summary>
    /// Interaction logic for BottomBar.xaml
    /// </summary>
    public partial class BottomBar : UserControl
    {
        Frame frame;
        public BottomBar()
        {
            InitializeComponent();
            frame = (Application.Current.MainWindow as MainWindow).PageFrame;
        }

        public void HomeClick(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("LoginPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }
    }
}
