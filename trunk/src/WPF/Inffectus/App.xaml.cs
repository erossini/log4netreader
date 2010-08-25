using System.Windows;
using Inffectus.Infrastructure.Ui;

namespace Inffectus
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //BootStrapper.Initialize();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Presenters.Show("Main");
        }
    }
}