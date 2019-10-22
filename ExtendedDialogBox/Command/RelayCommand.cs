using System;
using System.Windows.Input;

namespace ExtendedDialogBox.Command
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        internal RelayCommand(Action<object> execute)
        {
            this.execute = execute;
            canExecute = null;
        }

        internal RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        event EventHandler ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        bool ICommand.CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
