using System.Collections.ObjectModel;
using LogReader.Models.States.Paginators;

namespace LogReader.Models
{
    public interface IViewModel
    {
        ObservableCollection<LogEntry> Entries { get; set; }
        PageInfo Info { get; set; }
    }
}