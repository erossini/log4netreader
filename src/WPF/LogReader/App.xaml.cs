using Caliburn.PresentationFramework.ApplicationModel;
using LogReader.ViewModels;

namespace LogReader
{
    public partial class App : CaliburnApplication
    {
        protected override object CreateRootModel()
        {
            return new ShellViewModel();
        }
    }
}