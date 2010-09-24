using System.Collections.ObjectModel;

namespace LogReader.Models.States.Paginators
{
    public class FilePaginator : IPaginator
    {
        private readonly IViewModel _viewModel;
        private readonly Acumulator _acumulator;

        public FilePaginator(IViewModel viewModel, Acumulator acumulator)
        {
            _viewModel = viewModel;
            _acumulator = acumulator;
        }

        public void PreviousPage()
        {
            _acumulator.PreviosPage();
            Bind();
        }

        public void NextPage()
        {
            _acumulator.NextPage();
            Bind();
        }

        public void GoToPage(int index)
        {
            _acumulator.GoToPage(index);
            Bind();
        }

        public void Bind()
        {
            _viewModel.Entries = new ObservableCollection<LogEntry>(_acumulator.GetActivePage());
            _viewModel.Info = new PageInfo()
            {
                Pages = _acumulator.Pages,
                PageIndex = _acumulator.CurrentPage
            };
        }
    }
}