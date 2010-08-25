using System;
using Microsoft.Win32;

namespace Inffectus.Infrastructure.Readers
{
    public class LogSelector
    {
        public string Choose()
        {
            var dlg = new OpenFileDialog {
                              DefaultExt = ".xml",
                              Filter = "Xml documents (.xml)|*.xml"
                          };

            var result = dlg.ShowDialog();
            
            return result.Value ? dlg.FileName : String.Empty;
        }
    }
}