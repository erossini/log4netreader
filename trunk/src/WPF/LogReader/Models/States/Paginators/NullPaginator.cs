using System;

namespace LogReader.Models.States.Paginators
{
    public class NullPaginator : IPaginator
    {
        public void PreviousPage()
        {
            throw new NotImplementedException();
        }

        public void NextPage()
        {
            throw new NotImplementedException();
        }

        public void GoToPage(string index)
        {
            throw new NotImplementedException();
        }
    }
}