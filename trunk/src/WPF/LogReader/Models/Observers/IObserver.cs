namespace LogReader.Models.Observers
{
    public interface IObserver
    {
        void Notify(object o);
    }
}