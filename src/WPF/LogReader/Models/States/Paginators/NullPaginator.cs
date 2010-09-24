using System;

namespace LogReader.Models.States.Paginators
{
    public class NullPaginator : IPaginator
    {
        public void PreviousPage()
        {
        }

        public void NextPage()
        {
        }

        public void GoToPage(int index)
        {
        }

        public void Bind()
        {
        }
    }
}