namespace LogReader.Domain {
    public class PageInfo {
        #region Constants and Fields

        public int MaxPerPage = 100;

        #endregion

        #region Constructors and Destructors

        public PageInfo() {
            this.Index = 1;
        }

        #endregion

        #region Properties

        public bool HasPrevious {
            get {
                return this.Index > 1;
            }
        }

        public bool HasNext {
            get {
                return this.Index < this.Pages;
            }
        }

        public int Index { get; set; }
        public int Pages { get; set; }

        #endregion
    }
}