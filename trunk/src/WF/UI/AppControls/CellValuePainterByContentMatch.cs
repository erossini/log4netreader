using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LogReader.UI.AppControls {
    public class CellValuePainterByContentMatch {

        private Color _previousColor = Color.Empty;
        private Color _currentColor = Color.Empty;
        private string _currentThread = null;
        private string _previousThread = null;
        private int _colorIndex = 0;

        readonly List<Color> _colorsAlt = new List<Color> {
             Color.Olive, 
             Color.OliveDrab, 
             Color.Orange,
             Color.Orchid,
             Color.PaleGoldenrod,
             Color.PaleGreen,
             Color.PaleTurquoise,
             Color.PaleVioletRed,
             Color.PapayaWhip,
             Color.PeachPuff,
             Color.Peru,
             Color.Pink,
             Color.Plum,
             Color.Salmon
         };

        private void MoveNextColor() {
            _previousColor = _currentColor;

            _colorIndex++;
            if (_colorIndex == _colorsAlt.Count) _colorIndex = 0;

            _currentColor = _colorsAlt[_colorIndex];
        }

        public void Paint(DataGridViewCell cell) {
            var cellValue = cell.Value;
            var cellStyle = cell.Style;

            if (cellValue.ToString().Equals(this._currentThread)) {
                cellStyle.BackColor = this._currentColor;
                return;
            }

            if (cellValue.ToString().Equals(this._previousThread)) {
                cellStyle.BackColor = this._previousColor;
                return;
            }

            MoveNextColor();
            _previousThread = _currentThread;
            _currentThread = cellValue.ToString();
            cellStyle.BackColor = this._currentColor;
        }
    }
}