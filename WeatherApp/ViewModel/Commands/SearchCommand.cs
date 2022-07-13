using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherApp.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {

        public WeatherViewModel Vm { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public SearchCommand(WeatherViewModel vm)
        {
            Vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            var query = parameter as string;

            return !string.IsNullOrWhiteSpace(query);
        }

        public void Execute(object parameter)
        {
            Vm.MakeQuery();
        }

    }
}
