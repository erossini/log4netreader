using System.Collections.ObjectModel;
using LogReader.Models.Observers;

namespace LogReader.Models.States.Paginators
{
    public abstract class Paginator : IObserver
    {
        protected readonly IViewModel ViewModel;
        protected readonly Acumulator Acumulator;

        protected Paginator(IViewModel viewModel, Acumulator acumulator)
        {
            ViewModel = viewModel;
            Acumulator = acumulator;
            Acumulator.Subscribe(this);
        }

        public void Release()
        {
            Acumulator.Unsubscribe(this);
        }

        public virtual void PreviousPage()
        {
            Acumulator.PreviosPage();
            Bind();
        }

        public virtual void NextPage()
        {
            Acumulator.NextPage();
            Bind();
        }

        public virtual void GoToPage(int index)
        {
            Acumulator.GoToPage(index);
            Bind();
        }
        
        public virtual void Bind()
        {
            ViewModel.Entries = new ObservableCollection<LogEntry>(Acumulator.GetActivePage());
            ViewModel.Info = new PageInfo()
            {
                Pages = Acumulator.Pages,
                PageIndex = Acumulator.CurrentPage,
                Mode = ContentMode()
            };
        }

        protected abstract string ContentMode();
        
        public virtual void Notify(object o)
        {
        }
    }
}