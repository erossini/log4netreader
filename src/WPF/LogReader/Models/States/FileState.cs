using LogReader.Infrastructure.Readers;

namespace LogReader.Models.States
{
    public class FileState : State
    {
        private readonly Acumulator _acumulator;

        public FileState(Acumulator acumulator)
        {
            _acumulator = acumulator;
        }

        public override void Enter()
        {
            var logFileService = new LogFileService();
            var entries = logFileService.GetFileEntries();

            _acumulator.LoadEntries(entries);
        }

        public override void Leave()
        {
        }
    }
}