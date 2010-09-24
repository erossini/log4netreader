using LogReader.Models.States.Paginators;

namespace LogReader.Models.States
{
    public abstract class State
    {
        protected IPaginator Paginator = new NullPaginator();
        protected StateMachine StateMachine { get; private set; }
        
        public abstract void Enter();
        public virtual void Leave()
        {
            StateMachine = null;
        }

        protected State(StateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }

        public virtual void PreviousPage()
        {
            Paginator.PreviousPage();
        }

        public virtual void NextPage()
        {
            Paginator.NextPage();
        }

        public virtual void GoToPage(string index)
        {
            Paginator.GoToPage(index);
        }
    }
}