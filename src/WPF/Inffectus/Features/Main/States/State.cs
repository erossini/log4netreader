using System.Windows.Threading;

namespace Inffectus.Features.Main.States
{
    public abstract class State
    {
        public abstract void Enter();
        public abstract void Leave();
        
        public Model Model = new Model();

        public static State LogsLoadedFromFile()
        {
            return new ReadFromFileState();
        }

        public static State ListenToWireIncommingEvents(Dispatcher dispatcher)
        {
            return new ReadFromWire(dispatcher);
        }
    }
}