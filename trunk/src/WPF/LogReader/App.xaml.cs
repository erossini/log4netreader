using Caliburn.Castle;
using Caliburn.PresentationFramework.ApplicationModel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using LogReader.ViewModels;
using Microsoft.Practices.ServiceLocation;

namespace LogReader
{
    public partial class App : CaliburnApplication
    {
        protected override object CreateRootModel()
        {
            var binder = (DefaultBinder)Container.GetInstance<IBinder>();

            binder.EnableMessageConventions();
            binder.EnableBindingConventions();

            return Container.GetInstance<IShellViewModel>();
        }

        protected override IServiceLocator CreateContainer()
        {
            var container = new WindsorContainer();

            container
                .Register(Component.For<IShellViewModel>().ImplementedBy<ShellViewModel>().LifeStyle.Singleton);

            
            return new WindsorAdapter(container);
        }
    }
}