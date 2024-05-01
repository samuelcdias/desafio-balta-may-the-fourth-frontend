using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public class StarshipViewModel : ViewModelBase
{
    public string? Name { get; set; }
    public string? Model { get; set; } = string.Empty;
    public string? Manufacturer { get; set; }

    [JsonPropertyName("costInCredits")]
    public string? CostInCredits { get; set; }
    [JsonPropertyName("length")]
    public string? Length { get; set; }
    /// <summary>
    /// The maximum speed of this starship in the atmosphere.
    /// </summary>
    //[JsonPropertyName("max_atmosphering_speed")]
    [JsonPropertyName("maxAtmospheringSpeed")]
    public string? MaxSpeedAtmosphering { get; set; }
    /// <summary>
    /// The number of personnel needed to run or pilot this starship.
    /// </summary>
    public string? Crew { get; set; }
    public string? Passengers { get; set; }

    /// <summary>
    /// The maximum number of kilograms that this starship can transport.
    /// </summary>
    [JsonPropertyName("cargo_capacity")]
    public string? CargoCapacity { get; set; }

    [JsonPropertyName("hyperdrive_rating")]
    public string? HyperdriveRating { get; set; }

    /// <summary>
    /// Velocidade - megalight por hora (abreviado MGLT) foi uma unidade usada para medir a velocidade relativa subluz de naves estelares.
    /// </summary>
    [JsonPropertyName("megalights")]
    public string? Mglt { get; set; }
    public string? Consumables { get; set; }

    [JsonPropertyName("starship_class")]
    public string? StarshipClass { get; set; }
    public List<string>? Pilots { get; set; }
    public List<CharacterViewModel>? PilotsVM { get; set; }

    [JsonPropertyName("movies")]
    public List<BaseToListViewModel>? Films { get; set; }
    public List<MovieViewModel>? FilmsVM { get; set; }
}
