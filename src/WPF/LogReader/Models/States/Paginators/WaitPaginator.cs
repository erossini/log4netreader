using LogReader.Models.ViewModels;

namespace LogReader.Models.States.Paginators
{
    public class WaitPaginator : Paginator
    {
        public WaitPaginator(IShellViewModel viewModel, Acumulator acumulator) : base(viewModel, acumulator)
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