using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Inffectus.Infrastructure.Readers;
using Inffectus.Infrastructure.Services;
using Inffectus.Infrastructure.Ui;
using Inffectus.Model;

namespace Inffectus.Features.Main
{
    public class Presenter : AbstractPresenter<Model, View>
    {
        readonly LogFileService _logFileService;
        readonly InstantReader _instantReader;

        public Presenter()
        {
            _logFileService = new LogFileService();
            _instantReader = InstantReader.Current;
        }

        public void CallExit()
        {
            View.Close();
        }

        public void CallOpen()
        {
            var file = _logFileService.PickOne();

            Model = new Model()
                        {
                            Entries = new ObservableCollection<LogEntry>(file.Entries),
                            Errors = file.ErrorCount,
                            Warns = file.WarnCount,
                            Infos = file.InfoCount
                        };
        }

        public void CallListen()
        {
            Model = new Model()
            {
                Entries = new ObservableCollection<LogEntry>(new List<LogEntry>()),
                Errors = 0,
                Warns = 0,
                Infos = 0
            };

            //_instantReader.OnLogEntryReceived = entry => Model.Entries.Add(entry);
            //_instantReader.SetObserver(Model.Entries);
            _instantReader.Start();

            SetObserver o = new SetObserver(Method);
            View.Dispatcher.Invoke(o);
        }

        public delegate void SetObserver();
        

        public void Method()
        {
            _instantReader.SetObserver(Model.Entries, View.Dispatcher);
        }
    }
}