using LogReader.Infrastructure.Readers;

namespace LogReader.Models
{
    public class LogFileService
    {
        readonly LogReader.Infrastructure.Readers.LogReader _logReader;
        readonly LogSelector _logSelector;

        public LogFileService()
        {
            _logReader = new LogReader.Infrastructure.Readers.LogReader();
            _logSelector = new LogSelector();
        }

        public LogFile PickOne()
        {
            var fileName = _logSelector.Choose();

            if (string.IsNullOrEmpty(fileName))
                return LogFile.BuildEmpty();

            return _logReader.GetEntries(fileName);
        }
    }
}