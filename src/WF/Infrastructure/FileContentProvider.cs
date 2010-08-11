using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using LogReader.Domain;

namespace LogReader.Infrastructure {
    public class FileContentProvider{
        public List<LogEntry> GetContent(string fileName) {
            
            XElement xml;
            var itemIndex = 0;
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            using (var fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)) {
                TextReader log4netFile = new StreamReader(fileStream);

                var log4netFileContent = log4netFile.ReadToEnd().Replace("log4j:", string.Empty);

                xml = XElement.Parse("<root>" + log4netFileContent + "</root>");
            }

            var query = from e in xml.Elements()
                        select
                            new LogEntry()
                            {
                                Item = ++itemIndex,
                                TimeStamp = dt.AddMilliseconds(double.Parse(e.Attribute("timestamp").Value)).ToLocalTime(),
                                Level = e.Attribute("level").Value,
                                Thread = e.Attribute("thread").Value,
                                Message = StringFormatting.AddNewLines(e.Element("message").Value),
                                Throwable = StringFormatting.AddNewLines(this.GetValueOrDefault(e.Element("throwable"))),
                                Class = e.Element("locationInfo").Attribute("class").Value,
                                Method = e.Element("locationInfo").Attribute("method").Value,
                                File = e.Element("locationInfo").Attribute("file").Value,
                                Line = e.Element("locationInfo").Attribute("line").Value,
                                MachineName = this.GetElementValueByAttribute(e.Element("properties"), "log4jmachinename"),
                                HostName = this.GetElementValueByAttribute(e.Element("properties"), "log4net:HostName"),
                                UserName = this.GetElementValueByAttribute(e.Element("properties"), "log4net:UserName"),
                                App = this.GetElementValueByAttribute(e.Element("properties"), "log4japp")
                            };
            
            return query.ToList();
        }

        private string GetElementValueByAttribute(XElement element, string log4jmachinename) {
            var result = string.Empty;

            foreach (var xElement in element.Elements("data")) {

                if (log4jmachinename.Equals(xElement.Attribute("name").Value)) {
                    result = xElement.Attribute("value").Value;
                    break;
                }
            }

            return result;
        }

        private string GetValueOrDefault(XElement element) {
            return element == null ? string.Empty : element.Value;
        }

        
    }
}