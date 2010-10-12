using Caliburn.PresentationFramework.Commands;
using LogReader.Models;

namespace LogReader.Commands
{
    [Command]
    public class ListenWireCommand
    {
        private readonly StateMachine _appStateMachine;

        public ListenWireCommand(StateMachine appStateMachine)
        {
            _appStateMachine = appStateMachine;
        }

        public void Execute()
        {
            _appStateMachine.ShowLogsCommingOverWire();
        }
    }
}