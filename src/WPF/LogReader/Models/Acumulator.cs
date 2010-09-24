using System.Collections.Generic;

namespace LogReader.Models
{
    public class Acumulator
    {
        readonly List<LogEntry> _entries;

        public int ErrorCount;
        public int InfoCount;
        public int WarnCount;

        public Acumulator()
        {
            _entries = new List<LogEntry>();
        }

        public void AppendEntry(LogEntry entry)
        {
            switch (entry.Level)
            {
                case "INFO":
                    InfoCount++;break;
                case "WARN":
                    WarnCount++;break;
                case "ERROR":
                    ErrorCount++;break;
            }

            _entries.Add(entry);
        }

        public void LoadEntries(List<LogEntry> entries)
        {
            _entries.Clear();
            entries.ForEach(AppendEntry);
        }
    }
}