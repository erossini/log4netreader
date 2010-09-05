namespace Inffectus.Features.Main.States
{
    public abstract class State
    {
        protected readonly Presenter Presenter;
        public abstract void Enter();
        public abstract void Leave();

        protected State(Presenter presenter)
        {
            Presenter = presenter;
        }

        public static State MakeFileReader(Presenter presenter)
        {
            return new ReadFromFileState(presenter);
        }

        public static State MakeWireReader(Presenter presenter)
        {
            return new ReadFromWire(presenter);
        }
    }
}