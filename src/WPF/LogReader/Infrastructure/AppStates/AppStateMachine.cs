using System;
using LogReader.ViewModels;

namespace LogReader.Infrastructure.AppStates
{
    public class AppStateMachine
    {
        private IShellViewModel _model;
        private State _state;

        public void SetModel(IShellViewModel model)
        {
            _model = model;
            MoveTo(State.InNullState);
        }

        public void LoadFileLogs()
        {
            MoveTo(State.LogsLoadedFromFile);
        }

        public void ShowLogsCommingOverWire()
        {
            MoveTo(State.ListenToWireIncommingEvents);
        }

        public void PreviousPage()
        {
            _state.PreviousPage();
        }

        public void NextPage()
        {
            _state.NextPage();
        }

        public void GoToPage(string index)
        {
            _state.GoToPage(index);
        }

        private void MoveTo(Func<State> setState)
        {
            if (_state != null)
                _state.Leave();

            _state = setState();

            _state.Enter();

            _model.LoadState(_state.Model);
        }
    }
}