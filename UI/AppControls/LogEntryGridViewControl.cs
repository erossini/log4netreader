using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LogReader.Domain;

namespace LogReader.UI.AppControls {
    public partial class LogEntryGridViewControl : UserControl {
        #region Constants and Fields

        public Action<LogEntry> OnLogEntrySelected;

        private readonly LogEntryGridViewRowColorChangerByLoggingLevelDecorator _gridViewPainter =
            new LogEntryGridViewRowColorChangerByLoggingLevelDecorator();

        private readonly LogEntryGridViewRowInstantPopulationDecorator _rowAppender =
            new LogEntryGridViewRowInstantPopulationDecorator();

        private readonly LogEntryGroupBy_Thread_Class_Method_WithPaintedCellsDecorator _grouper = 
            new LogEntryGroupBy_Thread_Class_Method_WithPaintedCellsDecorator();

        private List<LogEntry> _content;

        #endregion

        #region Constructors and Destructors

        public LogEntryGridViewControl() {
            this.InitializeComponent();

            this._gridViewPainter.Decorate(this.dgvEntries);
            this._grouper.Decorate(this.dgvEntries);
            this._rowAppender.Decorate(this.dgvEntries);

            this.dgvEntries.CellClick += (sender, args) => {
                if(this.OnLogEntrySelected != null) {
                    foreach (DataGridViewRow row in this.dgvEntries.SelectedRows) {
                        var logEntry = row.DataBoundItem as LogEntry;

                        this.OnLogEntrySelected(logEntry);

                        break;
                    }
                }
            };
        }

        #endregion

        #region Public Methods

        public void AppendLogEntry(LogEntry logEntry) {
            this._rowAppender.Append(logEntry);
        }

        public void AsSearchResultsConfigured() {
            this.ShowJustCollumns("Item", "Message");
        }

        public void SelectAndScrollToEntry(LogEntry logEntry) {
            var selectedIndex = this._content.IndexOf(logEntry);

            if(this.dgvEntries.Rows.Count - 1 >= selectedIndex) {
                this.dgvEntries.FirstDisplayedScrollingRowIndex = selectedIndex;
                this.dgvEntries.Rows[selectedIndex].Selected = true;
                this.dgvEntries.Rows[selectedIndex].Cells[0].Selected = true;

                this.OnLogEntrySelected(logEntry);
            }
        }

        public void ShowEntries(List<LogEntry> logEntries) {
            this._content = logEntries;
            this.dgvEntries.DataSource = this._content;
        }

        public void StartInstantPopulation() {
            this._rowAppender.RefreshBinding();
        }

        #endregion

        #region Methods

        private void ShowJustCollumns(params string[] columnNames) {
            foreach (DataGridViewTextBoxColumn column in this.dgvEntries.Columns) {
                var isNotIn =
                    (from columnName in columnNames where columnName.Equals(column.Name) select columnName).Count() == 0;

                if(isNotIn) {
                    column.Visible = false;
                }
            }
        }

        #endregion
    }
}