using System.Collections.ObjectModel;
using Inffectus.Model;

namespace Inffectus.Features.Main
{
    public class Model
    {
        public ObservableCollection<LogEntry> Entries { get; set; }

        public int Errors { get; set; }
        public int Infos { get; set; }
        public int Warns { get; set; }

        public Model()
        {
            Entries = new ObservableCollection<LogEntry>();
        }

        public void AddEntry(LogEntry entry)
        {
            switch (entry.Level)
            {
                case "INFO":
                    Infos++; break;
                case "WARN":
                    Warns++; break;
                case "ERROR":
                    Errors++; break;
            }

            Entries.Add(entry);
        }

        public static Model BuildFromFile(LogFile logFile)
        {
            return new Model {
                           Entries = new ObservableCollection<LogEntry>(logFile.Entries),
                           Errors = logFile.ErrorCount,
                           Warns = logFile.WarnCount,
                           Infos = logFile.InfoCount
                       };
        }
    }
}