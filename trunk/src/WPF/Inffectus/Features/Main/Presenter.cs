using System.Collections.ObjectModel;
using Inffectus.Infrastructure.Services;
using Inffectus.Infrastructure.Ui;
using Inffectus.Model;

namespace Inffectus.Features.Main
{
    public class Presenter : AbstractPresenter<Model, View>
    {
        readonly LogFileService logFileService;

        public Presenter()
        {
            logFileService = new LogFileService();
        }

        public void CallExit()
        {
            View.Close();
        }

        public void CallOpen()
        {
            var file = logFileService.PickOne();

            Model = new Model()
                        {
                            Entries = new ObservableCollection<LogEntry>(file.Entries),
                            Errors = file.ErrorCount,
                            Warns = file.WarnCount,
                            Infos = file.InfoCount
                        };
        }
    }
}