using System;

namespace LogReader.Models.States.Paginators
{
    public class NullPaginator : Paginator
    {
        public NullPaginator(IViewModel viewModel, Acumulator acumulator) : base(viewModel, acumulator)
        {
        }

        protected override string ContentMode()
        {
            return "";
        }
    }
}