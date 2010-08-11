using System;

namespace LogReader.Infrastructure {
    public class StringFormatting {
        public static string AddNewLines(string input) {
            return string.IsNullOrEmpty(input.Trim()) ? string.Empty : input.Replace("\n", Environment.NewLine);
        }
    }
}