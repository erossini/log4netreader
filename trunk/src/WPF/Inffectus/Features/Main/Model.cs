using System.Collections.ObjectModel;
using Inffectus.Model;

namespace Inffectus.Features.Main
{
    public class Model
    {
        public ObservableCollection<LogEntry> Entries { get; set; }

        public int Errors { get; set; }
        public int Infos { get; set; }
        public int Warns { get; set; }
    }
}