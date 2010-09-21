using System.Collections.ObjectModel;
using Caliburn.PresentationFramework.ApplicationModel;
using LogReader.Infrastructure.AppStates;
using LogReader.Models;

namespace LogReader.ViewModels
{
    public class ShellViewModel : Presenter, IShellViewModel
    {
        private readonly AppStateMachine _appStateMachine;

        public ShellViewModel(AppStateMachine appStateMachine)
        {
            _appStateMachine = appStateMachine;
            _appStateMachine.SetModel(this);
        }

        public void ListenForLogEvents()
        {
            _appStateMachine.ShowLogsCommingOverWire();
        }

        public void OpenLogFile()
        {
            _appStateMachine.LoadFileLogs();
        }

        public void LoadState(Model model)
        {
            Entries = model.Entries;
        }

        private ObservableCollection<LogEntry> _entries;
        public ObservableCollection<LogEntry> Entries
        {
            get { return _entries; }
            set
            {
                _entries = value;
                NotifyOfPropertyChange("Entries");
            }
        }
    }

    public interface IShellViewModel {
        void LoadState(Model model);
    }
}