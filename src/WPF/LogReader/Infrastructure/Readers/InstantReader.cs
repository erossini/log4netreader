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
        private Model _model;
        private Dispatcher _dispatcher;
        private bool _isRunning;

        private delegate void AppenderDelegate(Model model, LoggingEvent loggingEvent);

        public void Start(Model model, Dispatcher dispatcher)
        {
            _model = model;
            _dispatcher = dispatcher;
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
        }
        
        protected override void Append(LoggingEvent loggingEvent)
        {
            if(_isRunning == false) return;

            _dispatcher.Invoke(new AppenderDelegate((model, @event) =>
            {
                var loggingEventDataProperties = loggingEvent.GetLoggingEventData().Properties;

                model.AddEntry(new LogEntry
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
                                            
            }), _model, loggingEvent);
        }

        private static string AddNewLines(string input)
        {
            return string.IsNullOrEmpty(input.Trim()) ? string.Empty : input.Replace("\n", Environment.NewLine);
        }
    }
}