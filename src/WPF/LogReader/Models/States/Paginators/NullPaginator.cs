using System;
using LogReader.Models.ViewModels;

namespace LogReader.Models.States.Paginators
{
    public class NullPaginator : Paginator
    {
        public NullPaginator(IShellViewModel viewModel, Acumulator acumulator) : base(viewModel, acumulator)
        {
        }

        protected override string ContentMode()
        {
            return "";
        }
    }
}