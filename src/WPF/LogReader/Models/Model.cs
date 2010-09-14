using System.Collections.ObjectModel;

namespace LogReader.Models
{
    public class Model
    {
        public Model()
        {
            Entries = new ObservableCollection<LogEntry>();
        }

        public ObservableCollection<LogEntry> Entries { get; set; }

        public int Errors { get; set; }
        public int Infos { get; set; }
        public int Warns { get; set; }

        public void AddEntry(LogEntry entry)
        {
            switch (entry.Level)
            {
                case "INFO":
                    Infos++;
                    break;
                case "WARN":
                    Warns++;
                    break;
                case "ERROR":
                    Errors++;
                    break;
            }

            Entries.Add(entry);
        }

        public void BuildFromFile(LogFile logFile)
        {
            foreach (LogEntry logEntry in logFile.Entries)
                AddEntry(logEntry);

            Errors = logFile.ErrorCount;
            Warns = logFile.WarnCount;
            Infos = logFile.InfoCount;
        }
    }
}