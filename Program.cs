using System;
using System.Windows.Forms;
using LogReader.UI.Shell;

namespace LogReader {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((ShellView)new ShellViewPresenter(new ShellView()).View);
        }
    }
}