using System;
using System.Runtime.Remoting;
using log4net;
using log4net.Config;
using log4net.Plugin;
using LogReader.Domain;
using LogReader.Infrastructure.Log4NetListener;

namespace LogReader.Infrastructure {
    public class InstantContentProvider {
        static readonly InstantAppender InstantAppender;
        
        static InstantContentProvider() {
            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            LogManager.GetRepository().PluginMap.Add(new RemoteLoggingServerPlugin("LoggingSink"));

            InstantAppender = new InstantAppender();
            BasicConfigurator.Configure(InstantAppender);

        }

        public void Start() {
            InstantAppender.Start();
        }

        public void Stop() {
            InstantAppender.Stop();
        }

        public Action<LogEntry> OnLogEntryReceived {
            set {
                InstantAppender.OnLogEntryReceived = value;
            }
        }
    }
}