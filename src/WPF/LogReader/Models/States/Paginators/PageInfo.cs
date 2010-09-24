using Caliburn.Core;

namespace LogReader.Models.States.Paginators
{
    public class PageInfo : PropertyChangedBase
    {
        private int _pages;

        public int Pages
        {
            get { return _pages; }
            set
            {
                _pages = value;
                NotifyOfPropertyChange("Pages");
            }
        }

        private int _pageIndex;

        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                _pageIndex = value;
                NotifyOfPropertyChange("PageIndex");
            }
        }
    }
}