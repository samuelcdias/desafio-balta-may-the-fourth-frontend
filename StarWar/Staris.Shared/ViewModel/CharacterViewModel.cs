using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public sealed class CharacterViewModel : ViewModelBase
{
    public string? Name { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }

    [JsonPropertyName("hair_color")]
    public string? HairColor { get; set; }
    public string? Mass { get; set; }

    [JsonPropertyName("skin_color")]
    public string? SkinColor { get; set; }

    [JsonPropertyName("eye_color")]
    public string? EyeColor { get; set; }

    [JsonPropertyName("birth_year")]
    public string? BirthYear { get; set; }
    public string? Gender { get; set; }

    public BaseToListViewModel? Homeworld { get; set; }
    public PlanetViewModel? HomeworldVM { get; set; }

    [JsonPropertyName("movies")]
    public List<BaseToListViewModel>? Films { get; set; }
    public List<MovieViewModel>? FilmsVM { get; set; }
    public List<BaseToListViewModel>? Vehicles { get; set; }
    public List<VehicleViewModel>? VehiclesVM { get; set; }
    public List<BaseToListViewModel>? Starships { get; set; }
    public List<StarshipViewModel>? StarshipsVM { get; set; }
    

}
