using Kit_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples
{
	public partial class App : Application
	{
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            window.Show();
        }
        
    }

}