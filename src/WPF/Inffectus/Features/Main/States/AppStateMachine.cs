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
            MoveTo(State.LogsLoadedFromFile);
        }

        public void ShowLogsCommingOverWire()
        {
            MoveTo(() => State.ListenToWireIncommingEvents(_presenter.ViewDispatcher));
        }

        private void MoveTo(Func<State> setState)
        {
            if (_state != null)
                _state.Leave();

            _state = setState();

            _state.Enter();

            _presenter.SetViewModel(_state.Model);
        }
    }
}