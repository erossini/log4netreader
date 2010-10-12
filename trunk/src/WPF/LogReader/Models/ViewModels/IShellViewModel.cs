using System.Collections.ObjectModel;
using LogReader.Models.States.Paginators;

namespace LogReader.Models.ViewModels
{
    public interface IShellViewModel
    {
        ObservableCollection<LogEntry> Entries { get; set; }
        PageInfo Info { get; set; }
        ObservableCollection<LogEntry> SearchResults { get; set; }
        ICriteriaViewModel Criteria { get; set; }
    }
}