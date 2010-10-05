using System.Collections.ObjectModel;
using Caliburn.PresentationFramework.ApplicationModel;
using LogReader.Models;
using LogReader.Models.States.Paginators;

namespace LogReader.ViewModels
{
    public class ShellViewModel : Presenter, IViewModel
    {
        private readonly StateMachine _appStateMachine;
        private CriteriaViewModel _criteria = new CriteriaViewModel();
        private ObservableCollection<LogEntry> _entries;
        private ObservableCollection<LogEntry> _searchResults;
        private PageInfo _info;

        public ShellViewModel(StateMachine appStateMachine)
        {
            _appStateMachine = appStateMachine;
            _appStateMachine.SetViewModel(this);
        }

        public CriteriaViewModel Criteria
        {
            get { return _criteria; }
            set
            {
                _criteria = value;
                NotifyOfPropertyChange("Criteria");
            }
        }

        #region IViewModel Members

        public ObservableCollection<LogEntry> Entries
        {
            get { return _entries; }
            set
            {
                _entries = value;
                NotifyOfPropertyChange("Entries");
            }
        }

        public ObservableCollection<LogEntry> SearchResults
        {
            get { return _searchResults; }
            set
            {
                _searchResults = value;
                NotifyOfPropertyChange("SearchResults");
            }
        }

        public PageInfo Info
        {
            get { return _info; }
            set
            {
                _info = value;
                NotifyOfPropertyChange("Info");
            }
        }

        #endregion

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
            int pageIndex = 1;

            if (int.TryParse(index, out pageIndex))
                _appStateMachine.GoToPage(pageIndex);
        }

        public void Search()
        {
            _appStateMachine.SearchBy(Criteria);
        }
    }
}