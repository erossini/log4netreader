namespace LogReader.Models.States.Paginators
{
    public class StreamPaginator : Paginator
    {
        public StreamPaginator(IViewModel viewModel, Acumulator acumulator) : base(viewModel, acumulator)
        {
        }

        protected override string ContentMode()
        {
            return "streaming ...";
        }

        public override void Notify(object o)
        {
            if (Acumulator.PageSize - 1 < ViewModel.Entries.Count)
                ViewModel.Entries.RemoveAt(0);
            
            ViewModel.Entries.Add((LogEntry)o);

            Acumulator.CurrentPage = Acumulator.Pages;

            ShowPageInfo();
        }

        private void ShowPageInfo()
        {
            ViewModel.Info = new PageInfo()
            {
                Pages = Acumulator.Pages,
                PageIndex = Acumulator.CurrentPage,
                Mode = "streaming ..."
            };
        }
    }
}