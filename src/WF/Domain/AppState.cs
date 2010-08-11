using System;
using System.Collections.Generic;
using System.Linq;
using LogReader.Infrastructure;
using LogReader.UI.Shell;

namespace LogReader.Domain {
    public enum AppStateType {
        Default,
        LoadContentFromFile,
        QueryByExample,
        RestoreOriginalState,
        ShowNextLogPage,
        ShowPage,
        ShowPrevLogPage,
        InstContentProviderStarted,
        InstContentProviderStopped
    }

    public class AppState {
        #region Constants and Fields

        private readonly List<LogEntry> _content = new List<LogEntry>();
        private readonly AppContentFilter _contentFilter = new AppContentFilter();
        private readonly InstantContentProvider _instContentProvider = new InstantContentProvider();
        private readonly List<LogEntry> _originalContent = new List<LogEntry>();
        private readonly IShellView _view;
        private PageInfo _pageInfo;

        #endregion

        #region Constructors and Destructors

        public AppState(IShellView view) {
            this._view = view;
            this._view.StateChangedTo(AppStateType.Default);
            this._instContentProvider.OnLogEntryReceived = this._view.DisplayReceivedLogEntry;
        }

        #endregion

        #region Public Methods

        public void GoToPage(LogEntry logEntry) {
            var pageNumber = 1;

            while (logEntry.Item > _pageInfo.MaxPerPage * pageNumber) {
                pageNumber++;
            }

            this.ShowPage(pageNumber);
        }

        public void LoadStateFromFile(string fileName) {
            var _fileContentProvider = new FileContentProvider();
            var logEntries = _fileContentProvider.GetContent(fileName);

            this.SetAppState(logEntries);

            this._pageInfo = this.PageInfoBuilder(logEntries);
            var pagedContent = this.FilterContentByPageInfo(this._content, this._pageInfo);

            this._view.ShowPage(pagedContent, this._pageInfo);
            this._view.StateChangedTo(AppStateType.LoadContentFromFile);
        }

        public void QueryByExample(LogEntry criteria) {
            var filteredContent = this._contentFilter.FilterByExample(this._content, criteria);

            var pageInfo = this.PageInfoBuilder(filteredContent);
            var pagedFirstSetOf100 = this.FilterContentByPageInfo(filteredContent, pageInfo);

            this._view.LogEntrySearch.ShowResults(pagedFirstSetOf100);
            this._view.StateChangedTo(AppStateType.QueryByExample);
        }

        public void RestoreOriginalState() {
            this._content.Clear();
            this._content.AddRange(this._originalContent);

            this._pageInfo = this.PageInfoBuilder(this._content);
            var pagedContent = this.FilterContentByPageInfo(this._content, this._pageInfo);

            this._view.ShowPage(pagedContent, this._pageInfo);
            this._view.StateChangedTo(AppStateType.RestoreOriginalState);
        }

        public void ShowNextLogPage() {
            if(!this._pageInfo.HasNext) {
                return;
            }

            this._pageInfo.Index++;
            this.ShowPagedContent();
            this._view.StateChangedTo(AppStateType.ShowNextLogPage);
        }

        public void ShowPage(int pageNumber) {
            if(pageNumber > this._pageInfo.Pages) {
                return;
            }
            this._pageInfo.Index = pageNumber;
            this.ShowPagedContent();
            this._view.StateChangedTo(AppStateType.ShowPage);
        }

        public void ShowPrevLogPage() {
            if(!this._pageInfo.HasPrevious) {
                return;
            }

            this._pageInfo.Index--;
            this.ShowPagedContent();
            this._view.StateChangedTo(AppStateType.ShowPrevLogPage);
        }

        public void StartInstantContentProvider() {
            this._instContentProvider.Start();
            this._view.StateChangedTo(AppStateType.InstContentProviderStarted);
        }

        public void StopInstantContentProvider() {
            this._instContentProvider.Stop();
            this._view.StateChangedTo(AppStateType.InstContentProviderStopped);
        }

        #endregion

        #region Methods

        private List<LogEntry> FilterContentByPageInfo(ICollection<LogEntry> logEntries, PageInfo info) {
            var skippedItems = (info.Index - 1) * info.MaxPerPage;
            var nrOfItemsToDisplay = info.MaxPerPage;

            if((skippedItems + info.MaxPerPage) > logEntries.Count) {
                nrOfItemsToDisplay = logEntries.Count - skippedItems;
            }

            return logEntries.Skip(skippedItems).Take(nrOfItemsToDisplay).ToList();
        }

        private PageInfo PageInfoBuilder(ICollection<LogEntry> results) {
            var newPageInfo = new PageInfo();

            if(results.Count > 0) {
                newPageInfo.Pages =
                    Convert.ToInt32(
                        Math.Ceiling(Convert.ToDouble(results.Count) / Convert.ToDouble(newPageInfo.MaxPerPage)));
            }

            return newPageInfo;
        }

        private void SetAppState(IEnumerable<LogEntry> logEntries) {
            this._content.Clear();
            this._originalContent.Clear();

            this._content.AddRange(logEntries);
            this._originalContent.AddRange(logEntries);
        }

        private void ShowPagedContent() {
            var pagedContent = this.FilterContentByPageInfo(this._content, this._pageInfo);
            this._view.ShowPage(pagedContent, this._pageInfo);
        }

        #endregion
    }
}