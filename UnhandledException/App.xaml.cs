using System.Windows;

namespace UnhandledException
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            new MainWindow().ShowDialog();
        }
    }
}
