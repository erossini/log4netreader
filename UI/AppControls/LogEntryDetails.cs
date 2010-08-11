using System.Windows.Forms;
using LogReader.Domain;

namespace LogReader.UI.AppControls {
    public partial class LogEntryDetails : UserControl {
        public LogEntryDetails() {
            this.InitializeComponent();
        }
        public void ShowEntry(LogEntry logEntry) {
            this.tbLevel.Text = logEntry.Level;
            this.tbItem.Text = logEntry.Item.ToString();
            this.tbClass.Text = logEntry.Class;
            this.tbFile.Text = logEntry.File;

            this.tbTimeStamp.Text = logEntry.TimeStamp.ToString();
            this.tbHostname.Text = logEntry.HostName;
            this.tbMethod.Text = logEntry.Method;

            this.tbMachineName.Text = logEntry.MachineName;
            this.tbUserName.Text = logEntry.UserName;
            this.tbLine.Text = logEntry.Line;

            this.tbThread.Text = logEntry.Thread;
            this.tbApp.Text = logEntry.App;

            this.tbMessage.Text = logEntry.Message;
            this.tbThrowable.Text = logEntry.Throwable;
        }
    }
}