using System;
using System.Diagnostics;
using System.Windows.Input;

namespace FISK_Prototype.ViewModel.Controls
{
    class SetPageContentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged; //MUST be implemented with the ICommand interface but is never used...

        MainWindowViewModel vm;
        public SetPageContentCommand(MainWindowViewModel mwvm)
        {
            vm = mwvm;
        }

        //parameter er "CommandParameter" fra binding på 
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine(parameter.ToString());

            //Skift siden med noget andet
            vm.SwapPageContent(parameter.ToString());
        }
    }
}
