using Caliburn.PresentationFramework.Commands;
using LogReader.Models;
using LogReader.Models.ViewModels;

namespace LogReader.Commands
{
    [Command]
    public class SearchCommand
    {
        private readonly StateMachine _machine;
        private readonly IShellViewModel _viewModel;

        public SearchCommand(StateMachine machine, IShellViewModel viewModel)
        {
            _machine = machine;
            _viewModel = viewModel;
        }

        public void Execute()
        {
            _machine.SearchBy(_viewModel.Criteria);
        }
    }
}