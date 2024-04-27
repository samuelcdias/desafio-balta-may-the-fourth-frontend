namespace Staris.Shared.ViewModel;

public class ResultViewModel<T>
{
    public int Count { get; set; }
    public int Page { get; set; }
    public int PerPage { get; set; }
    public int TotalPages { get; set; }
    public string? Next { get; set; }
    public string? Previous { get; set; }
    public List<T> Results { get; set; } = [];
}
