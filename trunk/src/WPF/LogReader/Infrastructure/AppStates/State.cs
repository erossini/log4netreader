using System.Windows.Threading;
using LogReader.Models;

namespace LogReader.Infrastructure.AppStates
{
    public abstract class State
    {
        public Model Model = new Model();
        public abstract void Enter();
        public abstract void Leave();
        public abstract void PreviousPage();
        public abstract void NextPage();
        public abstract void GoToPage(string index);

        public static State LogsLoadedFromFile()
        {
            return new ReadFromFileState();
        }

        public static State ListenToWireIncommingEvents()
        {
            return new ReadFromWire(Dispatcher.CurrentDispatcher);
        }

        public static State InNullState()
        {
            return new NullState();
        }

        #region Nested type: NullState

        private class NullState : State
        {
            public override void Enter()
            {
            }

            public override void Leave()
            {
            }

            public override void PreviousPage()
            {
            }

            public override void NextPage()
            {
            }

            public override void GoToPage(string index)
            {
            }
        }

        #endregion
    }
}