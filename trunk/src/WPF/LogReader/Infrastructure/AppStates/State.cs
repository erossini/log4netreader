using System.Windows.Threading;
using LogReader.Models;

namespace LogReader.Infrastructure.AppStates
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

        public static State ListenToWireIncommingEvents()
        {
            return new ReadFromWire(Dispatcher.CurrentDispatcher);
        }
    }
}