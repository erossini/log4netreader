using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LogReader.Models.Observers;

namespace LogReader.Models
{
    public class Acumulator : Subject
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

        public IEnumerable<LogEntry> Entries
        {
            get { return new ReadOnlyCollection<LogEntry>(_entries); }
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

        public bool IsNextPageLast()
        {
            return CurrentPage + 1 == Pages;
        }

        public bool IsCurrentlyOnLastPage()
        {
            return CurrentPage == Pages;
        }

        public void NextPage()
        {
            if (CurrentPage < Pages)
                CurrentPage++;
        }

        public void PreviosPage()
        {
            if (CurrentPage > 1)
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

            NotifyObservers(entry);
        }

        public void LoadEntries(List<LogEntry> entries)
        {
            _entries.Clear();
            entries.ForEach(AppendEntry);
        }
    }
}