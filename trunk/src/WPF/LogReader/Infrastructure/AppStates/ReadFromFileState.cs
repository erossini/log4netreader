using LogReader.Models;

namespace LogReader.Infrastructure.AppStates
{
    public class ReadFromFileState : State
    {
        private readonly LogFileService _logFileService;

        public ReadFromFileState()
        {
            _logFileService = new LogFileService();
        }

        public override void Enter()
        {
            var file = _logFileService.PickOne();
            
            Model.BuildFromFile(file);
        }

        public override void Leave()
        {
        }
    }
}