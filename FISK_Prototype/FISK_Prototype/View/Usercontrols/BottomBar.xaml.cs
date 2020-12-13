using System.Windows;
using System.Windows.Controls;

namespace FISK_Prototype.View.Usercontrols
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

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Appen vil nu lukke");
            Application.Current.Shutdown();
        }
    }
}
