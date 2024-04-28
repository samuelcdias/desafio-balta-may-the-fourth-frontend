namespace Staris.Shared.Configurations;

public static class Configuration
{
    public static string BaseUri { get; set; } 
    public static string DefaultUri { get; set; } = "https://staris-api.runasp.net/api/";

    public static string BuildPostParameters(string search, int page, int perPage, string sortBy, string sortOrder )
    {
        string result = "?";
        result += string.IsNullOrEmpty(search) ? "" : $"search={search}";
        result += page > 0 ? result.Length > 1 ? $"&page={page}" : $"page={page}" : "";
        result += perPage > 0 ? result.Length > 1 ? $"&perPage={perPage}" : $"perPage={perPage}" : "";
        result += string.IsNullOrEmpty(sortBy) ? "" : result.Length > 1 ? $"&sortBy={sortBy}" : $"sortBy={sortBy}";
        result += string.IsNullOrEmpty(sortOrder) ? "" : result.Length > 1 ? $"&sortOrder={sortOrder}" : $"sortOrder={sortOrder}";

        return result;
    }
}
