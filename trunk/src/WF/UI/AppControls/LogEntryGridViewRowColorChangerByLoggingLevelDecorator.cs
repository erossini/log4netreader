using System.Drawing;
using System.Windows.Forms;

namespace LogReader.UI.AppControls {
    public class LogEntryGridViewRowColorChangerByLoggingLevelDecorator {
        #region Public Methods

        public void Decorate(DataGridView dataGridView) {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataBindingComplete += (sender, args) => {
                foreach (DataGridViewRow r in dataGridView.Rows) {
                    var rowColor = Color.Empty;

                    switch (r.Cells["Level"].Value.ToString().ToUpper()) {
                        case "DEBUG":
                            rowColor = Color.FromArgb(255, 255, 255);
                            break;
                        case "INFO":
                            rowColor = Color.FromArgb(244, 212, 210);
                            break;
                        case "WARN":
                            rowColor = Color.FromArgb(232, 153, 164);
                            break;
                        case "ERROR":
                            rowColor = Color.FromArgb(255, 97, 89);
                            break;
                        case "FATAL":
                            rowColor = Color.FromArgb(255, 50, 71);
                            break;
                    }

                    var cellStyle = dataGridView.DefaultCellStyle.Clone();
                    cellStyle.BackColor = rowColor;
                    r.DefaultCellStyle = cellStyle;
                }
            };
        }

        #endregion
    }
}