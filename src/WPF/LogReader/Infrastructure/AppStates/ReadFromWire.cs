using System;
using System.Runtime.Remoting;
using System.Windows.Threading;
using log4net;
using log4net.Config;
using log4net.Plugin;
using LogReader.Infrastructure.Readers;

namespace LogReader.Infrastructure.AppStates
{
    public class ReadFromWire : State
    {
        private readonly Dispatcher _dispatcher;
        private static readonly InstantReader InstantReader;

        static ReadFromWire()
        {
            InstantReader = new InstantReader();

            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            LogManager.GetRepository().PluginMap.Add(new RemoteLoggingServerPlugin("LoggingSink"));

            BasicConfigurator.Configure(InstantReader);
        }

        public ReadFromWire(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public override void Enter()
        {
            InstantReader.Start(Model, _dispatcher);
        }

        public override void Leave()
        {
            InstantReader.Stop();
        }
    }
}