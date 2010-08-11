using System.Windows.Forms;

namespace LogReader.UI.AppControls {
    public class LogEntryGroupBy_Thread_Class_Method_WithPaintedCellsDecorator {
        
        private readonly CellValuePainterByContentMatch _threadColl = new CellValuePainterByContentMatch();
        //private readonly CellValuePainterByContentMatch _classColl = new CellValuePainterByContentMatch();

        public void Decorate(DataGridView gridView) {

            gridView.DataBindingComplete += (sender, args) =>
            {
                foreach (DataGridViewRow r in gridView.Rows) {
                    _threadColl.Paint(r.Cells["Thread"]);
                    //_classColl.Paint(r.Cells["Class"]);
                }
            };
        }
    }
}