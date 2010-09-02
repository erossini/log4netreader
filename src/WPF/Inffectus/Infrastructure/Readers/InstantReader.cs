using System;
using System.Collections.ObjectModel;
using System.Runtime.Remoting;
using System.Windows.Threading;
using Inffectus.Model;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Plugin;

namespace Inffectus.Infrastructure.Readers
{
    public class InstantReader : AppenderSkeleton
    {
        private InstantReader()
        {
        }

        public static InstantReader current;

        public static InstantReader Current
        {
            get
            {
                if (current == null){
                    current = new InstantReader();

                    RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
                    LogManager.GetRepository().PluginMap.Add(new RemoteLoggingServerPlugin("LoggingSink"));

                    BasicConfigurator.Configure(current);
                }
                return current;
            }
        }

        private static int _intemid;
        private bool _started;

        public Action<LogEntry> OnLogEntryReceived;

        protected override void Append(LoggingEvent loggingEvent)
        {
            var parameters = new object[] {_entries, loggingEvent};
            var del = new MyDel(Method);
            Dispatcher.Invoke(del, parameters);
        }

        public void Start()
        {
            _started = true;
        }

        public void Stop()
        {
            _started = false;
        }

        private static string AddNewLines(string input)
        {
            return string.IsNullOrEmpty(input.Trim()) ? string.Empty : input.Replace("\n", Environment.NewLine);
        }

        private ObservableCollection<LogEntry> _entries;
        private Dispatcher Dispatcher;

        public void SetObserver(ObservableCollection<LogEntry> entries, Dispatcher dispatcher)
        {
            _entries = entries;
            Dispatcher = dispatcher;
        }

        public delegate void MyDel(ObservableCollection<LogEntry> entries, LoggingEvent loggingEvent);

        public void Method(ObservableCollection<LogEntry> entries, LoggingEvent loggingEvent)
        {
            var loggingEventDataProperties = loggingEvent.GetLoggingEventData().Properties;

            entries.Add(new LogEntry
            {
                Item = ++_intemid,
                TimeStamp = loggingEvent.TimeStamp,
                Level = loggingEvent.Level.DisplayName,
                Thread = loggingEvent.ThreadName,
                Message = AddNewLines(loggingEvent.RenderedMessage),
                MachineName = loggingEventDataProperties["log4jmachinename"].ToString(),
                UserName = loggingEvent.UserName,
                HostName = loggingEventDataProperties["log4net:HostName"].ToString(),
                Throwable = AddNewLines(loggingEvent.GetExceptionString()),
                App = loggingEventDataProperties["log4japp"].ToString(),
                Class = loggingEvent.LocationInformation.ClassName,
                Method = loggingEvent.LocationInformation.MethodName,
                File = loggingEvent.LocationInformation.FileName,
                Line = loggingEvent.LocationInformation.LineNumber
            });
        }
    }
}