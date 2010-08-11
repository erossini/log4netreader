using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using LogReader.Domain;
using LogReader.UI.AppControls;
using LogReader.UI.HowTo;

namespace LogReader.UI.Shell {
    public partial class ShellView : Form, IShellView {
        #region Constants and Fields

        private readonly DragAndDropFileOpennerDecorator _fileOpenner = new DragAndDropFileOpennerDecorator();
        private readonly ShowItInTrayDecorator _showItInTray = new ShowItInTrayDecorator();

       #endregion

        #region Constructors and Destructors

        public ShellView() {
            this.InitializeComponent();
        }

        public void SetDecorators() {
            this._fileOpenner.Decorate(this, Presenter.OpenFileWithName);
            this._showItInTray.Decorate(this);
            
            this.logEntries.OnLogEntrySelected += this.entryDetails.ShowEntry;
            this.mainContiner.SplitterDistance = 0;
        }

        public ILogEntrySearchControl LogEntrySearch {
            get {
                return logEntrySearchControl;
            }
        }

        public void HighlightEntry(LogEntry logEntry) {
            this.logEntries.SelectAndScrollToEntry(logEntry);
        }

        #endregion

        #region Properties

        public ShellViewPresenter Presenter { get; set; }

        #endregion

        #region Implemented Interfaces

        #region IShellView

        public void DisplayReceivedLogEntry(LogEntry s) {
            this.logEntries.AppendLogEntry(s);
        }

        public string GetFileName() {
            var dialog = new OpenFileDialog();

            if(dialog.ShowDialog(this) == DialogResult.OK) {
                if(!string.IsNullOrEmpty(dialog.FileName)) {
                    return dialog.FileName.Trim();
                }
            }

            return string.Empty;
        }

        public void ShowPage(List<LogEntry> entries, PageInfo info) {
            this.logEntries.ShowEntries(entries);

            this.tbGotoPage.Text = info.Index.ToString();
            this.lblTotal.Text = this.lblTotal.Tag.ToString() + info.Pages;
            this.btnPrev.Enabled = info.HasPrevious;
            this.btnNext.Enabled = info.HasNext;
        }

        public void StateChangedTo(AppStateType stateType) {
            this.tsbLoad.Enabled = false;
            this.tsbStart.Enabled = false;
            this.tsbStop.Enabled = false;
            this.btnPrev.Enabled = false;
            this.btnNext.Enabled = false;
            this.tbSearch.Enabled = false;
            this.btnGoToPage.Enabled = false;
            this.tbGotoPage.Enabled = false;

            switch (stateType) {
                case AppStateType.LoadContentFromFile:
                case AppStateType.QueryByExample:
                case AppStateType.ShowNextLogPage:
                case AppStateType.ShowPage:
                case AppStateType.ShowPrevLogPage:
                case AppStateType.RestoreOriginalState: {
                    this.tsbLoad.Enabled = true;
                    this.tsbStart.Enabled = true;
                    this.btnPrev.Enabled = true;
                    this.btnNext.Enabled = true;
                    this.tbSearch.Enabled = true;
                    this.btnGoToPage.Enabled = true;
                    this.tbGotoPage.Enabled = true;
                }
                    break;
                case AppStateType.InstContentProviderStarted: {
                    this.tsbStop.Enabled = true;
                }
                    break;
                case AppStateType.InstContentProviderStopped:
                case AppStateType.Default:
                    this.tsbStart.Enabled = true;
                    this.tsbLoad.Enabled = true;
                    break;
            }
        }

        #endregion

        #endregion

        #region Methods

        private void btnGoToPage_Click(object sender, EventArgs e) {
            this.Presenter.GoToPage(this.tbGotoPage.Text);
        }

        private void btnNext_Click(object sender, EventArgs e) {
            this.Presenter.GetNextPage();
        }

        private void btnPrev_Click(object sender, EventArgs e) {
            this.Presenter.GetPrevPage();
        }

        public void ShowSearchPannel(bool isShown) {
            this.mainContiner.SplitterDistance = isShown ? 255 : 0;
            this.tbSearch.Checked = isShown;
            this.LogEntrySearch.ShowResults(new List<LogEntry>());
        }

        private void tbSearch_CheckedChanged(object sender, EventArgs e) {
            ShowSearchPannel(this.tbSearch.Checked);
        }

        private void tsbInfo_Click(object sender, EventArgs e) {
            new HowToView().ShowDialog(this);
        }

        private void tsbLoad_Click(object sender, EventArgs e) {
            try {
                this.Presenter.OpenFile();
            }
            catch (XmlException) {
                MessageBox.Show(
                    this,
                    "The log file is corrupted or file content is not a collection of log4j:event's",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsbStart_Click(object sender, EventArgs e) {
            this.logEntries.StartInstantPopulation();
            this.Presenter.StartLogListener();
        }

        private void tsbStop_Click(object sender, EventArgs e) {
            this.Presenter.StopLogListener();
        }

        #endregion
    }
}