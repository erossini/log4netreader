using System.Collections.Generic;
using System.Linq;

namespace LogReader.Models
{
    public class Acumulator
    {
        private readonly List<LogEntry> _entries;
        public int CurrentPage = 1;

        public int ErrorCount;
        public int InfoCount;
        public int PageSize = 10;
        public int Pages;
        public int WarnCount;

        public Acumulator()
        {
            _entries = new List<LogEntry>();
        }

        public List<LogEntry> GetActivePage()
        {
            return _entries
                .Skip((CurrentPage - 1)*PageSize)
                .Take(PageSize)
                .ToList();
        }

        public void GoToPage(int index)
        {
            if (index <= Pages)
                CurrentPage = index;
        }

        public void NextPage()
        {
            CurrentPage++;
        }

        public void PreviosPage()
        {
            CurrentPage--;
        }

        public void AppendEntry(LogEntry entry)
        {
            switch (entry.Level)
            {
                case "INFO":
                    InfoCount++;
                    break;
                case "WARN":
                    WarnCount++;
                    break;
                case "ERROR":
                    ErrorCount++;
                    break;
            }

            _entries.Add(entry);

            Pages = _entries.Count/PageSize + (_entries.Count%PageSize == 0 ? 0 : 1);
        }

        public void LoadEntries(List<LogEntry> entries)
        {
            _entries.Clear();
            entries.ForEach(AppendEntry);
        }
    }
}