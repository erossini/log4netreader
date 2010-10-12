using Caliburn.PresentationFramework.Commands;
using LogReader.Models;

namespace LogReader.Commands
{
    [Command]
    public class OpenFileCommand
    {
        private readonly StateMachine _appStateMachine;

        public OpenFileCommand(StateMachine appStateMachine)
        {
            _appStateMachine = appStateMachine;
        }

        public void Execute()
        {
            _appStateMachine.LoadFileLogs();
        }
    }
}