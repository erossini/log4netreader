using LogReader.Models.States.Paginators;
using LogReader.Models.ViewModels;

namespace LogReader.Models.States
{
    public abstract class State
    {
        protected Paginator Paginator;
        protected StateMachine StateMachine { get; private set; }

        public IShellViewModel ViewModel;
        public Acumulator Acumulator;

        public abstract void Enter();
        public virtual void Leave()
        {
            StateMachine = null;
        }

        protected State(StateMachine stateMachine)
        {
            StateMachine = stateMachine;

            if(stateMachine == null)
                return;

            ViewModel = stateMachine.ViewModel;
            Acumulator = stateMachine.Acumulator;
        }

        public virtual void PreviousPage()
        {
            Paginator.PreviousPage();
        }

        public virtual void NextPage()
        {
            Paginator.NextPage();
        }

        public virtual void GoToPage(int index)
        {
            Paginator.GoToPage(index);
        }
    }
}