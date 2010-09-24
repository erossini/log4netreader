using LogReader.Infrastructure.Readers;
using LogReader.Models.States.Paginators;

namespace LogReader.Models.States
{
    public class FileState : State
    {
        public FileState(StateMachine stateMachine):base(stateMachine)
        {
            Paginator = new FilePaginator();
        }

        public override void Enter()
        {
            var logFileService = new LogFileService();
            var entries = logFileService.GetFileEntries();

            StateMachine
                .Acumulator.LoadEntries(entries));
        }

        public override void Leave()
        {
        }
    }
}