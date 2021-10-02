using System;

namespace TestButtonStyle
{
    /// <summary>
    /// A command whose sole purpose is to 
    /// relay its functionality to other
    /// objects by invoking delegates. The
    /// default return value for the CanExecute
    /// method is 'true'.
    /// </summary>
    public class RelayCommand : BaseCommand
    {
        #region Private Members

        private Action<object> 		_execute;
        private Predicate<object> 	_canExecute;        

        #endregion

        #region Construction

        /// <summary>
        /// Creates a new command that can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        public RelayCommand(Action<object> execute) : this(execute, null)
        {}

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
        	if (execute == null) throw new ArgumentNullException("execute");

            _execute 	= execute;
            _canExecute = canExecute;           
        }

        #endregion

        #region ICommand Override Members
                
		/// <summary>
		/// Determine whether or not this command CanExecute.
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
        public override bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        /// <summary>
        /// Execute the command.
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter)
        {
        	if (this.CanExecute(parameter))
        	{
        		_execute(parameter);	
        	}        	
        }

        #endregion
    }
}