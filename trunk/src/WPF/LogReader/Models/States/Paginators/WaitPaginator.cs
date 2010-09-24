namespace LogReader.Models.States.Paginators
{
    public class WaitPaginator : Paginator
    {
        public WaitPaginator(IViewModel viewModel, Acumulator acumulator) : base(viewModel, acumulator)
        {
        }

        protected override string ContentMode()
        {
            return "wait ...";
        }

        public override void Notify(object o)
        {
            Bind();
        }
    }
}