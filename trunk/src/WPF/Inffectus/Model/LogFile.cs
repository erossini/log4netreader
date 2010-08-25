using System.Collections.Generic;
using System.Linq;

namespace Inffectus.Model
{
    public class LogFile
    {
        public int DebugCount;
        public List<LogEntry> Entries;

        public int ErrorCount;
        public int InfoCount;
        public int WarnCount;

        private LogFile(List<LogEntry> entries)
        {
            Entries = entries;

            InfoCount = CountEntriesByLevel("INFO");
            WarnCount = CountEntriesByLevel("WARN");
            ErrorCount = CountEntriesByLevel("ERROR");
            DebugCount = CountEntriesByLevel("DEBUG");
        }

        private int CountEntriesByLevel(string level)
        {
            return (from entry in Entries where entry.Level == level select entry).Count();
        }

        public static LogFile BuildFromEntries(List<LogEntry> entries)
        {
            return new LogFile(entries);
        }
        
        public static LogFile BuildEmpty()
        {
            return new LogFile(new List<LogEntry>());
        }


    }
}