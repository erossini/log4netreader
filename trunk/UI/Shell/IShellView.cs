using System.Collections.Generic;
using LogReader.Domain;
using LogReader.UI.AppControls;

namespace LogReader.UI.Shell {
    public interface IShellView {
        ShellViewPresenter Presenter { get; set; }

        string GetFileName();

        void DisplayReceivedLogEntry(LogEntry s);
        void ShowPage(List<LogEntry> logEntries, PageInfo info);

        void StateChangedTo(AppStateType stateType);

        void SetDecorators();

        ILogEntrySearchControl LogEntrySearch { get; }
        void HighlightEntry(LogEntry logEntry);

        void ShowSearchPannel(bool isShown);
    }
}