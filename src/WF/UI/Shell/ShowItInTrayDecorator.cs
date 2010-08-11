using System;
using System.Windows.Forms;

namespace LogReader.UI.Shell {
    public class ShowItInTrayDecorator {
        private ShellView _shellView;

        public void Decorate(ShellView shellView) {
            _shellView = shellView;

            _shellView.ni.MouseDoubleClick += this.ni_MouseDoubleClick;
            _shellView.Resize += this.ShellView_Resize;
        }

        private void ni_MouseDoubleClick(object sender, MouseEventArgs e) {
            _shellView.Show();
            _shellView.WindowState = FormWindowState.Normal;
        }

        private void ShellView_Resize(object sender, EventArgs e) {
            if (_shellView.WindowState == FormWindowState.Minimized)
                _shellView.Hide();
        }
    }
}