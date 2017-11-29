using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tandem
{
    /// <inheritdoc />
    /// <summary>
    /// This is a command used to avoid code behind
    /// class Command implements ICommand
    /// We use CanExecute to represent our condition, it uses boolean
    /// We use Execute to represent  logic in our command
    /// Delegate Command Action and Func is used, Func is an object that returns a bool
    /// Bool button is used for the button on the signUp page
    /// </summary>
    public class Command : ICommand
    {
        private readonly Action<object> _executeMethod;
        private readonly Func<object, bool> _canexecuteMethod;
        private bool _button;

        /// <summary>
        /// The 2 delegates are passed and the bool is passed in the Command
        /// We assign the parameters on to the variables used
        /// </summary>
        /// <param name="executeMethod"></param>
        /// <param name="canExecuteMethod"></param>
        /// <param name="button"></param>
        public Command(Action<object> executeMethod, Func<object, bool> canExecuteMethod, bool button)
        {
            this._executeMethod = executeMethod;
            this._canexecuteMethod = canExecuteMethod;
            _button = button;
        }

        /// <inheritdoc />
        /// <summary>
        /// CanExecute returns a boolean true or false
        /// If CanExecuteMethod is null it will return true
        /// else it return a canexecuteMethod parameter
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canexecuteMethod == null || _canexecuteMethod(parameter);
        }

        /// <inheritdoc />
        /// <summary>
        /// When we implement the ICommand Interface this Eventh will be implemented
        /// RequerySuggested is raised when we type something and because of this it will also raise the CanExecuteChanged event
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <inheritdoc />
        /// <summary>
        /// We Execute the Action delegate in here
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}