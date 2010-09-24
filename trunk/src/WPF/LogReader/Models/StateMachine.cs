using LogReader.Models.States;

namespace LogReader.Models
{
    public class StateMachine
    {
        private State _state = new NeutralState();
        private readonly Acumulator _acumulator = new Acumulator();

        public void LoadFileLogs()
        {
            TransitTo(new FileState(_acumulator));
        }

        public void ShowLogsCommingOverWire()
        {
            TransitTo(new ListeningState(_acumulator));
        }

        private void TransitTo(State setState)
        {
            _state.Leave();

            _state = setState;

            _state.Enter();
        }

        public void PreviousPage()
        {
            
        }
        public void NextPage()
        {
            
        }
        public void GoToPage(string index)
        {
            
        }
    }
}