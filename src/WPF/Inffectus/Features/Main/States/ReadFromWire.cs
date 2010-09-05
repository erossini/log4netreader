using System;
using System.Runtime.Remoting;
using Inffectus.Infrastructure.Readers;
using log4net;
using log4net.Config;
using log4net.Plugin;

namespace Inffectus.Features.Main.States
{
    public class ReadFromWire : State
    {
        private static readonly InstantReader InstantReader;

        static ReadFromWire()
        {
            InstantReader = new InstantReader();

            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            LogManager.GetRepository().PluginMap.Add(new RemoteLoggingServerPlugin("LoggingSink"));

            BasicConfigurator.Configure(InstantReader);
        }

        public ReadFromWire(Presenter presenter) : base(presenter)
        {
        }

        public override void Enter()
        {
            var model = new Model();

            Presenter.SetModel(model);
            InstantReader.Start(model, Presenter.Dispatcher);
        }

        public override void Leave()
        {
            InstantReader.Stop();
        }
    }
}