using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Remoting;
using Inffectus.Infrastructure.Readers;
using Inffectus.Infrastructure.Services;
using Inffectus.Infrastructure.Ui;
using Inffectus.Model;
using log4net;
using log4net.Config;
using log4net.Plugin;

namespace Inffectus.Features.Main
{
    public class Presenter : AbstractPresenter<Model, View>
    {
        readonly LogFileService _logFileService;
        InstantReader _instantReader;

        public Presenter()
        {
            _logFileService = new LogFileService();
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

            _instantReader = new InstantReader(Model.Entries, View.Dispatcher);

            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            LogManager.GetRepository().PluginMap.Add(new RemoteLoggingServerPlugin("LoggingSink"));

            BasicConfigurator.Configure(_instantReader);
        }
    }
}