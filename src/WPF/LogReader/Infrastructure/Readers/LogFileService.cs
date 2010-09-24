using System;
using System.Collections.Generic;
using LogReader.Models;
using Microsoft.Win32;

namespace LogReader.Infrastructure.Readers
{
    public class LogFileService
    {
        readonly LogReader _logReader;

        public LogFileService()
        {
            _logReader = new LogReader();
        }

        public List<LogEntry> GetFileEntries()
        {
            var fileName = Choose();

            if (string.IsNullOrEmpty(fileName))
                return new List<LogEntry>();

            return _logReader.GetEntries(fileName);
        }

        private string Choose()
        {
            var dlg = new OpenFileDialog
            {
                DefaultExt = ".xml",
                Filter = "Xml documents (.xml)|*.xml"
            };

            var result = dlg.ShowDialog();

            return result.Value ? dlg.FileName : String.Empty;
        }
    }
}