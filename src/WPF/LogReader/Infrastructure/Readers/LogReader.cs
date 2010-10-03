using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using LogReader.Models;
using Microsoft.Win32;

namespace LogReader.Infrastructure.Readers
{
    public class LogReader
    {
        public List<LogEntry> GetFileEntries()
        {
            var fileName = Choose();

            if (string.IsNullOrEmpty(fileName))
                return new List<LogEntry>();

            return GetEntries(fileName);
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

        public List<LogEntry> GetEntries(string logFileName)
        {
            var entries = new List<LogEntry>();
            string fileContent;

            var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var iIndex = 1;

            using (var fileStream = new FileStream(logFileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            using (var streamReader = new StreamReader(fileStream))
            {
                fileContent = string.Format("<root>{0}</root>", streamReader.ReadToEnd());
                streamReader.Close();
                fileStream.Close();
            }
            
            ////////////////////////////////////////////////////////////////////////////////
            var oStringReader = new StringReader(fileContent);
            var oXmlTextReader = new XmlTextReader(oStringReader) { Namespaces = false };
            while (oXmlTextReader.Read())
            {
                if ((oXmlTextReader.NodeType != XmlNodeType.Element) || (oXmlTextReader.Name != "log4j:event"))
                    continue;
                var logentry = new LogEntry { Item = iIndex };

                var dSeconds = Convert.ToDouble(oXmlTextReader.GetAttribute("timestamp"));
                logentry.TimeStamp = dt.AddMilliseconds(dSeconds).ToLocalTime();
                logentry.Thread = oXmlTextReader.GetAttribute("thread");

                logentry.Level = oXmlTextReader.GetAttribute("level");

                #region read xml
                ////////////////////////////////////////////////////////////////////////////////
                while (oXmlTextReader.Read())
                {
                    var breakLoop = false;
                    switch (oXmlTextReader.Name)
                    {
                        case "log4j:event":
                            breakLoop = true;
                            break;
                        default:
                            switch (oXmlTextReader.Name)
                            {
                                case ("log4j:message"):
                                    {
                                        logentry.Message = oXmlTextReader.ReadString();
                                        break;
                                    }
                                case ("log4j:data"):
                                    {
                                        switch (oXmlTextReader.GetAttribute("name"))
                                        {
                                            case ("log4jmachinename"):
                                                {
                                                    logentry.MachineName = oXmlTextReader.GetAttribute("value");break;
                                                }
                                            case ("log4net:HostName"):
                                                {
                                                    logentry.HostName = oXmlTextReader.GetAttribute("value");break;
                                                }
                                            case ("log4net:UserName"):
                                                {
                                                    logentry.UserName = oXmlTextReader.GetAttribute("value");break;
                                                }
                                            case ("log4japp"):
                                                {
                                                    logentry.App = oXmlTextReader.GetAttribute("value");break;
                                                }
                                        }
                                        break;
                                    }
                                case ("log4j:throwable"):
                                    {
                                        logentry.Throwable = oXmlTextReader.ReadString();
                                        break;
                                    }
                                case ("log4j:locationInfo"):
                                    {
                                        logentry.Class = oXmlTextReader.GetAttribute("class");
                                        logentry.Method = oXmlTextReader.GetAttribute("method");
                                        logentry.File = oXmlTextReader.GetAttribute("file");
                                        logentry.Line = oXmlTextReader.GetAttribute("line");
                                        break;
                                    }
                            }
                            break;
                    }
                    if (breakLoop) break;
                }
                ////////////////////////////////////////////////////////////////////////////////
                #endregion

                entries.Add(logentry);
                iIndex++;
            }

            return entries;
        }
    }
}