using System;
using System.Windows.Input;

namespace Calculator.Command
{
    internal class CalculatorCommand : ICommand
    {
        private Action _action;

        public CalculatorCommand(Action action)
        {
            this._action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _action();
    }
}