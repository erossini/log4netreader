using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogReader.Domain;

namespace LogReader.UI.AppControls {
    public class LogEntryGridViewRowInstantPopulationDecorator {
        #region Constants and Fields

        private BindingSource _bindingSource;
        private List<LogEntry> _logEntries;
        private DataGridView _gridView;

        #endregion

        #region Public Methods

        public void Decorate(DataGridView gridView) {
            this._gridView = gridView;
            this._logEntries = new List<LogEntry>();

            this.RefreshBinding();
        }

        public void RefreshBinding() {
            this._bindingSource = new BindingSource() { DataSource = this._logEntries };
            this._gridView.DataSource = this._bindingSource;
        }

        #endregion

        internal void Append(LogEntry s) {
            Action WorkItem = () =>
            {
                this._logEntries.Insert(0, s);

                if (this._logEntries.Count > 100) {
                    this._logEntries.RemoveAt(this._logEntries.Count - 1);
                }

                this._bindingSource.ResetBindings(false);
            };

            if (this._gridView.InvokeRequired) {
                if (this._gridView.InvokeRequired) {
                    this._gridView.Invoke((EventHandler)((sender, args) => WorkItem()));
                } else {
                    WorkItem();
                }
            }

        }
    }
}