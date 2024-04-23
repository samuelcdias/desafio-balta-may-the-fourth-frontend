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

    public string? Homeworld { get; set; }
    public PlanetViewModel? HomeworldVM { get; set; }
    public List<string>? Films { get; set; }
    public List<MovieViewModel>? Movies { get; set; }
    public List<string>? Vehicles { get; set; }
    public List<VehicleViewModel>? VehiclesList { get; set; }
    public List<string>? Starships { get; set; }
    public List<StarshipViewModel>? StarshipsList { get; set; }
    

}
