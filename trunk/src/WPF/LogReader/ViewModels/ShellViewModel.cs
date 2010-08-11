using Caliburn.Core;

namespace LogReader.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private string message;

        public ShellViewModel()
        {
            Message = "My First Message";
        }

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                NotifyOfPropertyChange("Message");
            }
        }

        public void ChangeMessage()
        {
            Message = "Hello World";
        }
    }
}