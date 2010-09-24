using LogReader.Infrastructure.Readers;
using LogReader.Models.States.Paginators;

namespace LogReader.Models.States
{
    public class FileState : State
    {
        public FileState(StateMachine stateMachine):base(stateMachine)
        {
            Paginator = new FilePaginator(ViewModel, Acumulator);
        }

        public override void Enter()
        {
            var logFileService = new LogFileService();
            var entries = logFileService.GetFileEntries();

            Acumulator.LoadEntries(entries);

            Paginator.Bind();
        }

        public override void Leave()
        {
        }
    }
}