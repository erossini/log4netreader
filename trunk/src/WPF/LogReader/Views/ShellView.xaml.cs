﻿using System.Windows.Controls;
using LogReader.Models;

namespace LogReader.Views
{
    public partial class ShellView : UserControl
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void EntrySelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var logentry = listView1.SelectedItem as LogEntry;

            if (logentry == null) return;

            image1.Source = logentry.Image;
            textBoxLevel.Text = logentry.Level;
            textBoxTimeStamp.Text = logentry.TimeStamp.ToString();
            textBoxMachineName.Text = logentry.MachineName;
            textBoxThread.Text = logentry.Thread;
            textBoxItem.Text = logentry.Item.ToString();
            textBoxHostName.Text = logentry.HostName;
            textBoxUserName.Text = logentry.UserName;
            textBoxApp.Text = logentry.App;
            textBoxClass.Text = logentry.Class;
            textBoxMethod.Text = logentry.Method;
            textBoxLine.Text = logentry.Line;
            textBoxLog.Text = logentry.LogFile;
            textBoxMessage.Text = logentry.Message;
            textBoxThrowable.Text = logentry.Throwable;
            textBoxfile.Text = logentry.File;
        }
    }
}
