using System;
using System.ComponentModel;
using System.Windows.Input;

namespace TestButtonStyle
{
	/// <summary>
	/// Description of Window1ViewModel.
	/// </summary>
	public class Window1ViewModel : INotifyPropertyChanged
	{
		private ICommand _buttonBackCommand;
		private ICommand _buttonNextCommand;
		private string _pageLebel;
		private string _buttonBackLabel;
		private string _buttonNextLabel;
		
		public Window1ViewModel()
		{
			_buttonBackCommand = new RelayCommand(param => OnButtonBackClicked());
			_buttonNextCommand = new RelayCommand(param => OnButtonNextClicked());
			PageLabel = "page 1";
			ButtonBackLabel = "Close";
			ButtonNextLabel = "Next";
		}
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public string PageLabel
		{
			get
			{
				return _pageLebel;
			}
			
			set
			{
				if (_pageLebel != value)
				{
					_pageLebel = value;
					OnPropertyChanged("PageLabel");
				}
			}
		}
		
		public string ButtonBackLabel
		{
			get
			{
				return _buttonBackLabel;
			}
			
			set
			{
				if (_buttonBackLabel != value)
				{
					_buttonBackLabel = value;
					OnPropertyChanged("ButtonBackLabel");
				}
			}
		}
		
		public string ButtonNextLabel
		{
			get
			{
				return _buttonNextLabel;
			}
			
			set
			{
				if (_buttonNextLabel != value)
				{
					_buttonNextLabel = value;
					OnPropertyChanged("ButtonNextLabel");
				}
			}
		}
		
		public ICommand ButtonBackCommand
		{
			get
			{
				return _buttonBackCommand;	
			}
		}
		
		public ICommand ButtonNextCommand
		{
			get
			{
				return _buttonNextCommand;	
			}
		}
		
		private void OnButtonBackClicked()
		{
			if (PageLabel == "page 1")
			{
				//do nothing
			}
			else if (PageLabel == "page 2")
			{
				PageLabel = "page 1";
				ButtonBackLabel = "Close";
				ButtonNextLabel = "Next";
			}
			else if (PageLabel == "page 3")
			{
				PageLabel = "page 2";
				ButtonBackLabel = "Back";
				ButtonNextLabel = "Next";
			}			       
		}
		
		private void OnButtonNextClicked()
		{
			if (PageLabel == "page 1")
			{
				PageLabel = "page 2";
				ButtonBackLabel = "Back";
				ButtonNextLabel = "Next";
			}
			else if (PageLabel == "page 2")
			{
				PageLabel = "page 3";
				ButtonBackLabel = "Back";
				ButtonNextLabel = "Send";
			}
			else if (PageLabel == "page 3")
			{
				//do nothing
			}
		}
		
		protected void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}		
	}
}
