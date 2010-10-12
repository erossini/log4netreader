using Caliburn.Core;
using LogReader.Models.ViewModels;

namespace LogReader.ViewModels
{
    public class CriteriaViewModel : PropertyChangedBase, ICriteriaViewModel
    {
        private string _app;
        private string _class;
        private string _file;
        private string _hostName;
        private int _item;
        private string _level;
        private string _line;
        private string _machineName;
        private string _message;
        private string _method;
        private string _thread;
        private string _throwable;
        private string _userName;

        #region ICriteriaViewModel Members

        public int Item
        {
            get { return _item; }
            set
            {
                _item = value;
                NotifyOfPropertyChange("Item");
            }
        }

        public string Thread
        {
            get { return _thread; }
            set
            {
                _thread = value;
                NotifyOfPropertyChange("Thread");
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange("Message");
            }
        }

        public string MachineName
        {
            get { return _machineName; }
            set
            {
                _machineName = value;
                NotifyOfPropertyChange("MachineName");
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange("UserName");
            }
        }

        public string HostName
        {
            get { return _hostName; }
            set
            {
                _hostName = value;
                NotifyOfPropertyChange("HostName");
            }
        }

        public string App
        {
            get { return _app; }
            set
            {
                _app = value;
                NotifyOfPropertyChange("App");
            }
        }

        public string Throwable
        {
            get { return _throwable; }
            set
            {
                _throwable = value;
                NotifyOfPropertyChange("Throwable");
            }
        }

        public string Class
        {
            get { return _class; }
            set
            {
                _class = value;
                NotifyOfPropertyChange("Class");
            }
        }

        public string Method
        {
            get { return _method; }
            set
            {
                _method = value;
                NotifyOfPropertyChange("Method");
            }
        }

        public string File
        {
            get { return _file; }
            set
            {
                _file = value;
                NotifyOfPropertyChange("File");
            }
        }

        public string Line
        {
            get { return _line; }
            set
            {
                _line = value;
                NotifyOfPropertyChange("Line");
            }
        }

        public string Level
        {
            get { return _level; }
            set
            {
                _level = value;
                NotifyOfPropertyChange("Level");
            }
        }

        #endregion
    }
}