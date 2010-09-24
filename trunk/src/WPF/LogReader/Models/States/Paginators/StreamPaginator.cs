using System;
using System.Collections.ObjectModel;
using LogReader.Models.Observers;

namespace LogReader.Models.States.Paginators
{
    public class StreamPaginator : IPaginator, IObserver
    {
        private readonly IViewModel _viewModel;
        private readonly Acumulator _acumulator;

        public StreamPaginator(IViewModel viewModel, Acumulator acumulator)
        {
            _viewModel = viewModel;
            _acumulator = acumulator;

            _acumulator.Subscribe(this);
        }

        public void PreviousPage()
        {
        }

        public void NextPage()
        {
        }

        public void GoToPage(int index)
        {
        }

        public void Bind()
        {
            _viewModel.Entries = new ObservableCollection<LogEntry>();
        }

        public void Notify(object o)
        {
            //_viewModel.Entries.RemoveAt(0);
            _viewModel.Entries.Add((LogEntry)o);
        }
    }
}