using System;

namespace Inffectus.Features.Main.States
{
    public class AppStateMachine
    {
        private readonly Presenter _presenter;
        private State _state;

        public AppStateMachine(Presenter presenter)
        {
            _presenter = presenter;
        }

        public void LoadFileLogs()
        {
            MoveTo(()=> State.MakeFileReader(_presenter));
        }

        public void ShowLogsCommingOverWire()
        {
            MoveTo(() => State.MakeWireReader(_presenter));
        }

        private void MoveTo(Func<State> setState)
        {
            if (_state != null)
                _state.Leave();

            _state = setState();

            _state.Enter();
        }
    }
}