using LogReader.Domain;

namespace LogReader.UI.Shell {
    public class ShellViewPresenter {
        private readonly IShellView _view;
        private readonly AppState _state;

        public ShellViewPresenter(IShellView view) {
            this._view = view;
            this._view.Presenter = this;
            this._view.SetDecorators();
            this._view.LogEntrySearch.OnSearchByExample +=this.OnSearchByExample;
            this._view.LogEntrySearch.OnLogEntrySelected +=this.OnSearchResultSelectedGoToItsPage;

            this._state = new AppState(view);
        }

        private void OnSearchResultSelectedGoToItsPage(LogEntry logEntry) {
            this._state.GoToPage(logEntry);
            this._view.HighlightEntry(logEntry);
        }

        private void OnSearchByExample(LogEntry criteria) {
            this._state.QueryByExample(criteria);
        }

        public IShellView View {
            get {
                return this._view;
            }
        }

        public void OpenFile() {
            var fileName = this.View.GetFileName();
            this.OpenFileWithName(fileName);
        }

        public void OpenFileWithName(string file) {
            if (!string.IsNullOrEmpty(file)) {
                this._state.LoadStateFromFile(file);
                this._view.ShowSearchPannel(false);
            }
        }

        public void GetNextPage() {
            this._state.ShowNextLogPage();
        }

        public void GetPrevPage() {
            this._state.ShowPrevLogPage();
        }

        public void GoToPage(string pageNumber) {
            var gotoPageNumber = 1;

            if(int.TryParse(pageNumber, out gotoPageNumber))
                this._state.ShowPage(gotoPageNumber);
        }

        public void StartLogListener() {
            this._view.ShowSearchPannel(false);
            this._state.StartInstantContentProvider();
        }

        public void StopLogListener() {
            this._state.StopInstantContentProvider();
        }

        public void ShowOriginalContent() {
            this._state.RestoreOriginalState();
        }
    }
}