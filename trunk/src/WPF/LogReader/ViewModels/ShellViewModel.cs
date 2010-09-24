using System.Collections.ObjectModel;
using Caliburn.PresentationFramework.ApplicationModel;
using LogReader.Models;
using LogReader.Models.States.Paginators;

namespace LogReader.ViewModels
{
    public class ShellViewModel : Presenter, IViewModel
    {
        private readonly StateMachine _appStateMachine;

        public ShellViewModel(StateMachine appStateMachine)
        {
            _appStateMachine = appStateMachine;
            _appStateMachine.SetViewModel(this);
        }

        public void ListenForLogEvents()
        {
            _appStateMachine.ShowLogsCommingOverWire();
        }

        public void OpenLogFile()
        {
            _appStateMachine.LoadFileLogs();
        }

        public void PreviousPage()
        {
            _appStateMachine.PreviousPage();
        }
        
        public void NextPage()
        {
            _appStateMachine.NextPage();
        }
        
        public void GoToPage(string index)
        {
            var pageIndex = 1;

            if(int.TryParse(index, out pageIndex))
                _appStateMachine.GoToPage(pageIndex);
        }

        private ObservableCollection<LogEntry> _entries;
        public ObservableCollection<LogEntry> Entries
        {
            get { return _entries; }
            set
            {
                _entries = value;
                NotifyOfPropertyChange("Entries");
            }
        }

        private PageInfo _info;
        public PageInfo Info
        {
            get { return _info; }
            set
            {
                _info = value;
                NotifyOfPropertyChange("Info");
            }
        }
    }
}