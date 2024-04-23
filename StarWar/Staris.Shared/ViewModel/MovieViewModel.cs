using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public sealed class MovieViewModel: ViewModelBase
{
    public string? Title { get; set; }
    [JsonPropertyName("Episode_id")]
    public int Episode { get; set; }

    [JsonPropertyName("Opening_crawl")]
    public string? OpeningCrawl { get; set; }
    public string? Director { get; set; }
    public string? Producer { get; set; }

    [JsonPropertyName("Release_date")]
    public string? ReleaseDate { get; set; }
    public List<string>? Characters { get; set; }
    public List<CharacterViewModel>? CharactersVM { get; set; }
    public List<string>? Planets { get; set; }
    public List<PlanetViewModel>? PlanetsVM { get; set; }
    public List<string>? Vehicles { get; set; }
    public List<VehicleViewModel>? VehiclesVM { get; set; }
    public List<string>? Starships { get; set; }
    public List<StarshipViewModel>? StarshipsVM { get; set; }
    public List<string>? Species { get; set; }
    

}
