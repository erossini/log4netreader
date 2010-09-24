namespace LogReader.Models.States
{
    public abstract class State
    {
        public abstract void Enter();
        public abstract void Leave();
    }
}