using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LogReader.ViewModels;

namespace LogReader.Models
{
    public class AcumulatorSearcher
    {
        public ObservableCollection<LogEntry> QueryByCriteria(IEnumerable<LogEntry> logEntries, CriteriaViewModel criteria)
        {
            if (logEntries.Count() == 0)
                return new ObservableCollection<LogEntry>();

            var results = new List<LogEntry>();
            results.AddRange(logEntries);

            if (this.IsSet(criteria.Level))
                results = (from entry in results where entry.Level == criteria.Level select entry).ToList();

            if (criteria.Item != 0)
                results = (from entry in results where entry.Item == criteria.Item select entry).ToList();

            if (this.IsSet(criteria.Class))
                results = (from entry in results where entry.Class.Contains(criteria.Class) select entry).ToList();
            if (this.IsSet(criteria.File))
                results = (from entry in results where entry.File.Contains(criteria.File) select entry).ToList();

            if (this.IsSet(criteria.HostName))
                results = (from entry in results where entry.HostName.Contains(criteria.HostName) select entry).ToList();
            if (this.IsSet(criteria.Method))
                results = (from entry in results where entry.Method.Contains(criteria.Method) select entry).ToList();


            if (this.IsSet(criteria.MachineName))
                results = (from entry in results where entry.MachineName.Contains(criteria.MachineName) select entry).ToList();
            if (this.IsSet(criteria.UserName))
                results = (from entry in results where entry.UserName.Contains(criteria.UserName) select entry).ToList();
            if (this.IsSet(criteria.Line))
                results = (from entry in results where entry.Line == criteria.Line select entry).ToList();

            if (this.IsSet(criteria.Thread))
                results = (from entry in results where entry.Thread == criteria.Thread select entry).ToList();
            if (this.IsSet(criteria.App))
                results = (from entry in results where entry.App == criteria.App select entry).ToList();

            if (this.IsSet(criteria.Message))
                results = (from entry in results where entry.Message.Contains(criteria.Message) select entry).ToList();
            if (this.IsSet(criteria.Throwable))
                results = (from entry in results where entry.Throwable.Contains(criteria.Throwable) select entry).ToList();

            return new ObservableCollection<LogEntry>(results);
        }

        private bool IsSet(string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}