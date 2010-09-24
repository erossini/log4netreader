namespace LogReader.Models.States.Paginators
{
    public interface IPaginator
    {
        void PreviousPage();
        void NextPage();
        void GoToPage(int index);
        void Bind();
    }
}