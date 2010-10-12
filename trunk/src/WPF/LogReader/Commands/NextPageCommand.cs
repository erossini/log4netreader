using Caliburn.PresentationFramework.Commands;
using LogReader.Models;

namespace LogReader.Commands
{
    [Command]
    public class NextPageCommand
    {
        private readonly StateMachine _machine;

        public NextPageCommand(StateMachine machine)
        {
            _machine = machine;
        }

        public void Execute()
        {
            _machine.NextPage();
        }
    }
}