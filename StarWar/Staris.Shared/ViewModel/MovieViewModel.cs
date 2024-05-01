using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public sealed class MovieViewModel : ViewModelBase
{
    public string? Title { get; set; }
    public int Episode { get; set; }

    public string? OpeningCrawl { get; set; }
    public string? Director { get; set; }

    [JsonPropertyName("production")]
    public string? Producer { get; set; }

    public string? ReleaseDate { get; set; }
    public List<BaseToListViewModel>? Characters { get; set; }
    public List<CharacterViewModel>? CharactersVM { get; set; }
    public List<BaseToListViewModel>? Planets { get; set; }
    public List<PlanetViewModel>? PlanetsVM { get; set; }
    public List<BaseToListViewModel>? Vehicles { get; set; }
    public List<VehicleViewModel>? VehiclesVM { get; set; }
    public List<BaseToListViewModel>? Starships { get; set; }
    public List<StarshipViewModel>? StarshipsVM { get; set; }
    public List<BaseToListViewModel>? Species { get; set; }
    public List<SpecieViewModel>? SpeciesVM { get; set; }


}
