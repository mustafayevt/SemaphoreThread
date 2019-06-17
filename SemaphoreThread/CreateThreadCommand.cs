using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SemaphoreThread
{
    public class CreateThreadCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        ViewModel ViewModel;

        public CreateThreadCommand(ViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
