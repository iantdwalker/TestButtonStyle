using System;
using System.Windows.Input;

namespace TestButtonStyle
{
	/// <summary>
	/// BaseCommand provides shared ICommand functionality.
	/// </summary>
	public abstract class BaseCommand : ICommand
	{
		#region ICommand Members
		
		/// <summary>
		/// CanExecuteChanged event.
		/// </summary>
		public event EventHandler CanExecuteChanged;		
	
		/// <summary>
		/// Execute the command.
		/// </summary>
		/// <param name="parameter"></param>
		public abstract void Execute(object parameter);
		
		/// <summary>
		/// Determine whether or not this command CanExecute.
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		public virtual bool CanExecute(object parameter)
		{
			return true;
		}
		
		#endregion
		
		#region Protected Members	
		
		/// <summary>
		/// Fires the CanExecuteChanged event.
		/// </summary>
		protected virtual void OnCanExecuteChanged()
		{
			if (CanExecuteChanged != null)
			{
				CanExecuteChanged(this, new EventArgs());
			}
		}
		
		#endregion		
	}
}
