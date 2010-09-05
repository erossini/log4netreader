using Inffectus.Features.Main.States;
using Inffectus.Infrastructure.Ui;

namespace Inffectus.Features.Main
{
    public class Presenter : AbstractPresenter<Model, View>
    {
        private readonly AppStateMachine _stateMachine;

        public Presenter()
        {
            _stateMachine = new AppStateMachine(this);
        }

        public void CallExit()
        {
            View.Close();
        }

        public void CallOpen()
        {
            _stateMachine.LoadFileLogs();
        }

        public void CallListen()
        {
            _stateMachine.ShowLogsCommingOverWire();
        }
    }
}