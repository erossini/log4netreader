using Caliburn.PresentationFramework.Commands;
using LogReader.Models;

namespace LogReader.Commands
{
    [Command]
    public class GoToPageCommand
    {
        private readonly StateMachine _machine;

        public GoToPageCommand(StateMachine machine)
        {
            _machine = machine;
        }

        public void Execute(string index)
        {
            _machine.GoToPage(int.Parse(index));
        }

        public bool CanExecute(string index)
        {
            int gotoPage;
            var indexIsANumber = int.TryParse(index, out gotoPage);
            var isNotEmpty = string.IsNullOrEmpty(index) == false;

            return isNotEmpty && indexIsANumber ;
        }
    }
}