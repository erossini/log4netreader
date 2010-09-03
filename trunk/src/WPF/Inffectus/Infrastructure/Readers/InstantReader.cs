using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using Inffectus.Model;
using log4net.Appender;
using log4net.Core;

namespace Inffectus.Infrastructure.Readers
{
    public class InstantReader : AppenderSkeleton
    {
        private static int _intemid;
        private readonly ObservableCollection<LogEntry> _entries;
        private readonly Dispatcher _dispatcher;

        private delegate void AppenderDelegate(ObservableCollection<LogEntry> entries, LoggingEvent loggingEvent);

        public InstantReader(ObservableCollection<LogEntry> entries, Dispatcher dispatcher)
        {
            _entries = entries;
            _dispatcher = dispatcher;
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            _dispatcher.Invoke(new AppenderDelegate((entries, @event) =>
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
                                            
            }), _entries, loggingEvent);
        }

        private static string AddNewLines(string input)
        {
            return string.IsNullOrEmpty(input.Trim()) ? string.Empty : input.Replace("\n", Environment.NewLine);
        }
    }
}