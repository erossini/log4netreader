using System;
using log4net.Appender;
using log4net.Core;
using LogReader.Domain;

namespace LogReader.Infrastructure.Log4NetListener {
    public class InstantAppender : AppenderSkeleton {

        private static int _intemid;
        private bool _started;

        public Action<LogEntry> OnLogEntryReceived;

        protected override void Append(LoggingEvent loggingEvent) {
            if ((this.OnLogEntryReceived == null) || (this._started == false)) 
                return;

            var loggingEventDataProperties = loggingEvent.GetLoggingEventData().Properties;
            
            this.OnLogEntryReceived(new LogEntry {
                                                     Item = ++_intemid,
                                                     TimeStamp = loggingEvent.TimeStamp,
                                                     Level = loggingEvent.Level.DisplayName,
                                                     Thread = loggingEvent.ThreadName,
                                                     Message = StringFormatting.AddNewLines(loggingEvent.RenderedMessage),
                                                     MachineName = loggingEventDataProperties["log4jmachinename"].ToString(),
                                                     UserName = loggingEvent.UserName,
                                                     HostName = loggingEventDataProperties["log4net:HostName"].ToString(),
                                                     Throwable = StringFormatting.AddNewLines(loggingEvent.GetExceptionString()),
                                                     App = loggingEventDataProperties["log4japp"].ToString(),
                                                     Class = loggingEvent.LocationInformation.ClassName,
                                                     Method = loggingEvent.LocationInformation.MethodName,
                                                     File = loggingEvent.LocationInformation.FileName,
                                                     Line = loggingEvent.LocationInformation.LineNumber
                                                 });
        }

        public void Start() {
            this._started = true;
        }

        public void Stop() {
            this._started = false;
        }
    }
}