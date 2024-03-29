using System;
using LogReader.Models.States;
using LogReader.Models.ViewModels;
using LogReader.ViewModels;

namespace LogReader.Models
{
    public class StateMachine
    {
        private State _state = new NeutralState();
        public readonly Acumulator Acumulator = new Acumulator();
        private readonly AcumulatorSearcher _acumulatorSearcher = new AcumulatorSearcher();
        public IShellViewModel ViewModel;

        public StateMachine(IShellViewModel viewModel)
        {
            ViewModel = viewModel;
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
        public void GoToPage(int index)
        {
            _state.GoToPage(index);
        }

        public void SearchBy(ICriteriaViewModel criteria)
        {
            ViewModel.SearchResults = _acumulatorSearcher
                .QueryByCriteria(Acumulator.Entries, criteria);
        }
    }
}