using System;
using System.Windows.Input;

namespace ExtendedDialogBox.Command
{
    internal class RelayCommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        internal RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        internal event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        internal bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        internal void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
