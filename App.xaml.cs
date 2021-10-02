using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;

namespace TestButtonStyle
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window1 window = new Window1();            
            var viewModel = new Window1ViewModel();           
            window.DataContext = viewModel;

            window.Show();
        }
	}
}