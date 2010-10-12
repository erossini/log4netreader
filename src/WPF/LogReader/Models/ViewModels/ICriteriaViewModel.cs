namespace LogReader.Models.ViewModels
{
    public interface ICriteriaViewModel
    {
        int Item { get; set; }
        string Thread { get; set; }
        string Message { get; set; }
        string MachineName { get; set; }
        string UserName { get; set; }
        string HostName { get; set; }
        string App { get; set; }
        string Throwable { get; set; }
        string Class { get; set; }
        string Method { get; set; }
        string File { get; set; }
        string Line { get; set; }
        string Level { get; set; }
    }
}