using System;
using System.Windows.Forms;

namespace LogReader.UI.Shell {
    public class DragAndDropFileOpennerDecorator {

        public void Decorate(ShellView view, Action<string> OnFileDropped) {
            view.AllowDrop = true;

            view.DragEnter += (sender, args) =>
            {
                if (args.Data.GetDataPresent(DataFormats.FileDrop))
                    args.Effect = DragDropEffects.Copy;
                else
                    args.Effect = DragDropEffects.None;

            };

            view.DragDrop += (sender, args) =>
            {
                var a = (Array)args.Data.GetData(DataFormats.FileDrop);
                if (a != null) {
                    string firstFileName = a.GetValue(0).ToString();

                    if (OnFileDropped != null)
                        OnFileDropped(firstFileName);
                }

                view.Activate();
            };
        }
    }
}