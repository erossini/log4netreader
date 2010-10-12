using Caliburn.PresentationFramework.Commands;
using LogReader.Models;

namespace LogReader.Commands
{
    [Command]
    public class PreviousPageCommand
    {
        private readonly StateMachine _machine;

        public PreviousPageCommand(StateMachine machine)
        {
            _machine = machine;
        }

        public void Execute()
        {
            _machine.PreviousPage();
        }
    }
}