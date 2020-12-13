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
            Page home = new LoginPage();
            PageContent = home;

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
                //case "About":
                //    PageContent = new About();
                //    break;
                //case "Contact":
                //    PageContent = new Contact();
                //    break;
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