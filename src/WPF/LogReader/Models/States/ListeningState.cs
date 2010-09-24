using System;
using System.Runtime.Remoting;
using System.Windows.Threading;
using log4net;
using log4net.Config;
using log4net.Plugin;
using LogReader.Infrastructure.Readers;
using LogReader.Models.States.Paginators;

namespace LogReader.Models.States
{
    public class ListeningState : State
    {
        private static readonly InstantReader InstantReader;

        static ListeningState()
        {
            InstantReader = new InstantReader();

            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            LogManager.GetRepository().PluginMap.Add(new RemoteLoggingServerPlugin("LoggingSink"));

            BasicConfigurator.Configure(InstantReader);
        }

        public ListeningState(StateMachine stateMachine):base(stateMachine)
        {
            Paginator = new StreamPaginator();
        }

        public override void Enter()
        {
            InstantReader.Start(StateMachine.Acumulator, Dispatcher.CurrentDispatcher);
        }

        public override void Leave()
        {
            InstantReader.Stop();
        }
    }
}