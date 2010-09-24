using System.Collections.ObjectModel;

namespace LogReader.Models
{
    public interface IViewModel
    {
        ObservableCollection<LogEntry> Entries { get; set; }
    }
}