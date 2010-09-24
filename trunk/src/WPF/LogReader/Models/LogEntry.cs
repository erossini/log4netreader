using System;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace LogReader.Models
{

    [Serializable]
    public class LogEntry
    {
        public int Item { get; set; }
        public BitmapSource Image { get; set; }
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

        public LogEntry()
        {
            Image = SelectImageByLevel("");
        }

        private string _level;
        public string Level
        {
            get { return _level; }
            set
            {
                _level = value;
                Image = SelectImageByLevel(value);
            }
        }
        
        private DateTime _timeStamp = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private BitmapSource SelectImageByLevel(string value)
        {
            var icon = SystemIcons.Asterisk;

            switch (value)
            {
                case "ERROR":
                    {
                        icon = SystemIcons.Error; break;
                    }
                case "INFO":
                    {
                        icon = SystemIcons.Information; break;
                    }
                case "DEBUG":
                    {
                        icon = SystemIcons.Question; break;
                    }
                case "WARN":
                    {
                        icon = SystemIcons.Warning; break;
                    }
                case "FATAL":
                    {
                        icon = SystemIcons.Hand; break;
                    }
                default:
                    {
                        icon = SystemIcons.Asterisk; break;
                    }
            }

            return Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, null);
        }
    }
}