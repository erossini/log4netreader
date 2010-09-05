using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Remoting;
using System.Windows.Threading;
using Inffectus.Features.Main.States;
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

        readonly AppStateMachine _stateMachine;

        public Presenter()
        {

            _stateMachine = new AppStateMachine(this);
        }

        public Dispatcher Dispatcher
        {
            get { return View.Dispatcher; }
        }

        public void CallExit()
        {
            View.Close();
        }

        public void CallOpen()
        {
            _stateMachine.LoadFileLogs();
        }

        public void CallListen()
        {
            _stateMachine.ShowLogsCommingOverWire();
        }

        public void SetModel(Model model)
        {
            Model = model;
        }
    }
}