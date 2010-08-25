using Inffectus.Infrastructure.Readers;
using Inffectus.Model;

namespace Inffectus.Infrastructure.Services
{
    public class LogFileService
    {
        readonly LogReader logReader;
        readonly LogSelector logSelector;

        public LogFileService()
        {
            logReader = new LogReader();
            logSelector = new LogSelector();
        }

        public LogFile PickOne()
        {
            var fileName = logSelector.Choose();

            if (string.IsNullOrEmpty(fileName))
                return LogFile.BuildEmpty();

            return logReader.GetEntries(fileName);
        }
    }
}