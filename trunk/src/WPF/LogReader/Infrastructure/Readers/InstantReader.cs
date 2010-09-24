using System;
using System.Windows.Threading;
using log4net.Appender;
using log4net.Core;
using LogReader.Models;

namespace LogReader.Infrastructure.Readers
{
    public class InstantReader : AppenderSkeleton
    {
        private static int _intemid;
        private Acumulator _acumulator;
        private Dispatcher _dispatcher;
        private bool _isRunning;

        private delegate void AppenderDelegate(Acumulator model, LoggingEvent loggingEvent);

        public void Start(Acumulator acumulator, Dispatcher currentDispatcher)
        {
            _acumulator = acumulator;
            _dispatcher = currentDispatcher;
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            if(_isRunning == false) return;

            _dispatcher.Invoke(new AppenderDelegate((acumulator, @event) =>
            {
                var loggingEventDataProperties = loggingEvent.GetLoggingEventData().Properties;

                acumulator.AppendEntry(new LogEntry
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
                                            
            }), _acumulator, loggingEvent);
        }

        private static string AddNewLines(string input)
        {
            return string.IsNullOrEmpty(input.Trim()) ? string.Empty : input.Replace("\n", Environment.NewLine);
        }
    }
}