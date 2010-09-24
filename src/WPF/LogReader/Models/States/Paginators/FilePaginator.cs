namespace LogReader.Models.States.Paginators
{
    public class FilePaginator : Paginator
    {
        public FilePaginator(IViewModel viewModel, Acumulator acumulator) : base(viewModel, acumulator)
        {
        }

        protected override string ContentMode()
        {
            return "file content ...";
        }
    }
}