using LogReader.Models.States;

namespace LogReader.Models
{
    public class StateMachine
    {
        private State _state = new NeutralState();
        public readonly Acumulator Acumulator = new Acumulator();
        private IViewModel _viewModel;

        public void SetViewModel(IViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void LoadFileLogs()
        {
            TransitTo(new FileState(this));
        }

        public void ShowLogsCommingOverWire()
        {
            TransitTo(new ListeningState(this));
        }

        private void TransitTo(State setState)
        {
            _state.Leave();

            _state = setState;

            _state.Enter();
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
    }
}