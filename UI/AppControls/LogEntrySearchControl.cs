using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogReader.Domain;

namespace LogReader.UI.AppControls {
    public interface ILogEntrySearchControl {
        void ShowResults(List<LogEntry> logEntries);
        Action<LogEntry> OnSearchByExample { get; set;}
        Action<LogEntry> OnLogEntrySelected { get; set; }
    }

    public partial class LogEntrySearchControl : UserControl, ILogEntrySearchControl {

        
        public LogEntrySearchControl() {
            this.InitializeComponent();

            this.searchResults.AsSearchResultsConfigured();
        }

        public void ShowResults(List<LogEntry> logEntries) {
            this.searchResults.ShowEntries(logEntries);
        }

        public Action<LogEntry> OnSearchByExample {get; set; }
        public Action<LogEntry> OnLogEntrySelected {
            get { return this.searchResults.OnLogEntrySelected; }
            set { this.searchResults.OnLogEntrySelected = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (this.OnSearchByExample != null) this.OnSearchByExample(this.GetCriteria());
        }

        public void SetCriteria(LogEntry logEntry) {
            this.tbLevel.Text = logEntry.Level;
            this.tbItem.Text = logEntry.Item.ToString();
            this.tbClass.Text = logEntry.Class;
            this.tbFile.Text = logEntry.File;

            this.tbHostname.Text = logEntry.HostName;
            this.tbMethod.Text = logEntry.Method;

            this.tbMachineName.Text = logEntry.MachineName;
            this.tbUserName.Text = logEntry.UserName;
            this.tbLine.Text = logEntry.Line;

            this.tbThread.Text = logEntry.Thread;
            this.tbApp.Text = logEntry.App;

            this.tbMessage.Text = logEntry.Message;
            this.tbException.Text = logEntry.Throwable;
        }

        public LogEntry GetCriteria() {
            var logEntry = new LogEntry();
            var logItem = 0;

            logEntry.Level = this.tbLevel.Text;

            if (int.TryParse(this.tbItem.Text, out logItem))
                logEntry.Item = logItem;

            logEntry.Class = this.tbClass.Text;
            logEntry.File = this.tbFile.Text;

            logEntry.HostName = this.tbHostname.Text;
            logEntry.Method = this.tbMethod.Text;

            logEntry.MachineName = this.tbMachineName.Text;
            logEntry.UserName = this.tbUserName.Text;
            logEntry.Line = this.tbLine.Text;

            logEntry.Thread = this.tbThread.Text;
            logEntry.App = this.tbApp.Text;

            logEntry.Message = this.tbMessage.Text;
            logEntry.Throwable = this.tbException.Text;

            return logEntry;
        }
    }
}