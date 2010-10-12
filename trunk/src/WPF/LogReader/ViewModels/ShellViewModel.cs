using System.Collections.ObjectModel;
using Caliburn.Core;
using LogReader.Models;
using LogReader.Models.States.Paginators;
using LogReader.Models.ViewModels;

namespace LogReader.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IShellViewModel
    {
        private ICriteriaViewModel _criteria = new CriteriaViewModel();
        private ObservableCollection<LogEntry> _entries;
        private PageInfo _info;
        private ObservableCollection<LogEntry> _searchResults;

        #region IViewModel Members

        public ICriteriaViewModel Criteria
        {
            get { return _criteria; }
            set
            {
                _criteria = value;
                NotifyOfPropertyChange(() => Criteria);
            }
        }

        public ObservableCollection<LogEntry> Entries
        {
            get { return _entries; }
            set
            {
                _entries = value;
                NotifyOfPropertyChange(() => Entries);
            }
        }

        public ObservableCollection<LogEntry> SearchResults
        {
            get { return _searchResults; }
            set
            {
                _searchResults = value;
                NotifyOfPropertyChange(() => SearchResults);
            }
        }

        public PageInfo Info
        {
            get { return _info; }
            set
            {
                _info = value;
                NotifyOfPropertyChange(() => Info);
            }
        }

        #endregion
    }
}