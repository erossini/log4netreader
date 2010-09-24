using Caliburn.PresentationFramework.ApplicationModel;
using LogReader.Models;

namespace LogReader.ViewModels
{
    public class ShellViewModel : Presenter, IViewModel
    {
        private readonly StateMachine _appStateMachine;

        public ShellViewModel(StateMachine appStateMachine)
        {
            _appStateMachine = appStateMachine;
            _appStateMachine.SetViewModel(this);
        }

        public void ListenForLogEvents()
        {
            _appStateMachine.ShowLogsCommingOverWire();
        }

        public void OpenLogFile()
        {
            _appStateMachine.LoadFileLogs();
        }

        public void PreviousPage()
        {
            _appStateMachine.PreviousPage();
        }
        
        public void NextPage()
        {
            _appStateMachine.NextPage();
        }
        
        public void GoToPage(string index)
        {
            _appStateMachine.GoToPage(index);
        }
    }
}