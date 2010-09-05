using Inffectus.Infrastructure.Services;

namespace Inffectus.Features.Main.States
{
    public class ReadFromFileState : State
    {
        private readonly LogFileService _logFileService;

        public ReadFromFileState(Presenter presenter) : base(presenter)
        {
            _logFileService = new LogFileService();
        }

        public override void Enter()
        {
            var file = _logFileService.PickOne();
            var model = Model.BuildFromFile(file);

            Presenter.SetModel(model);
        }

        public override void Leave()
        {
        }
    }
}