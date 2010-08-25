using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace Inffectus.Model
{
    public enum LogImageType
    {
        Debug = 0,
        Error = 1,
        Fatal = 2,
        Info = 3,
        Warn = 4,
        Custom = 5
    }

    [Serializable]
    public class LogEntry
    {
        private static readonly Dictionary<LogImageType, BitmapSource> ImageList =
            new Dictionary<LogImageType, BitmapSource> {
                {LogImageType.Debug, Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Question.Handle, Int32Rect.Empty, null)},
                {LogImageType.Error, Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Error.Handle, Int32Rect.Empty, null)},
                {LogImageType.Fatal, Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Hand.Handle, Int32Rect.Empty, null)},
                {LogImageType.Info, Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Information.Handle, Int32Rect.Empty, null)},
                {LogImageType.Warn, Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Warning.Handle, Int32Rect.Empty, null)},
                {LogImageType.Custom, Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Asterisk.Handle, Int32Rect.Empty, null)}
            };

        public static BitmapSource Images(LogImageType type)
        {
            return ImageList[type];
        }

        private DateTime timeStamp = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public int Item { get; set; }
        public BitmapSource Image { get; set; }
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

        public static bool JustFileName { get; set; }

        public string LogFile
        {
            get { return JustFileName ? Path.GetFileName(logFile) : logFile; }
            set { logFile = value; }
        }

        private string logFile = string.Empty;

        public string FullLogPath
        { get { return LogFile; } }

        public string ShortLogFile
        { get { return Path.GetFileName(LogFile); } }

        public LogEntry()
        {
            Thread = string.Empty;
            Level = string.Empty;
            Image = ImageList[LogImageType.Custom];
            Line = string.Empty;
            File = string.Empty;
            Method = string.Empty;
            Class = string.Empty;
            Throwable = string.Empty;
            App = string.Empty;
            HostName = string.Empty;
            UserName = string.Empty;
            MachineName = string.Empty;
            Message = string.Empty;
        }
    }
}