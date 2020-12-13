using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using FISK_Prototype.ViewModel.Controls;
using FISK_Prototype.View.Pages;


namespace FISK_Prototype.ViewModel.Controls
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string Title { get { return "FISK Prototype"; } }
        public Page PageContent { get; set; }
        private ICommand setPageContentCommand { get; set; }
        public ICommand SetPageContentCommand
        {
            get { return setPageContentCommand; }
        }
        public MainWindowViewModel()
        {
            Page loginPage = new LoginPage();
            PageContent = loginPage;

            //Sætte SetPageContentCommand
            setPageContentCommand = new SetPageContentCommand(this);
        }
        //This command executes/invokes SwapPageContent by setting PageContent to another object.
        public void SwapPageContent(string name)
        {
            switch (name)
            {
                case "LoginPage":
                    PageContent = new LoginPage();
                    break;
                case "LoginSubPage1":
                    PageContent = new LoginSubPage1();
                    break;
                case "LoginSubPage2":
                    PageContent = new LoginSubPage2();
                    break;
                default:
                    PageContent = new LoginPage();
                    break;
            }
            OnPropertyChanged("PageContent");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string x)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        }
    }
}