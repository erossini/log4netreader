using System;

namespace LogReader.Domain {
    public class LogEntry {
        public enum IMAGE_TYPE {
            DEBUG = 0,
            ERROR = 1,
            FATAL = 2,
            INFO = 3,
            WARN = 4,
            CUSTOM = 5
        }

        public int Item { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Level { get; set; }
        public string Thread { get; set; }
        public string Message { get; set; }
        public string MachineName { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public string App { get; set; }
        public string Throwable { get; set; }
        public string Class { get; set; }
        public string Method { get; set; }
        public string File { get; set; }
        public string Line { get; set; }

        public LogEntry() {
            this.TimeStamp = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.Level = string.Empty;
            this.Thread = string.Empty;
            this.Message = string.Empty;
            this.MachineName = string.Empty;
            this.UserName = string.Empty;
            this.HostName = string.Empty;
            this.App = string.Empty;
            this.Throwable = string.Empty;
            this.Class = string.Empty;
            this.Method = string.Empty;
            this.File = string.Empty;
            this.Line = string.Empty;
        }
    }
}