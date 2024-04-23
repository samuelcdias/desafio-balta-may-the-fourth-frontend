using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public class VehicleViewModel: ViewModelBase
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? Manufacturer { get; set; }
    /// <summary>
    /// O custo deste veículo novo, em Créditos Galácticos
    /// </summary>
    [JsonPropertyName("cost_in_credits")]
    public string? CostInCredits { get; set; }
    public string? Length { get; set; }
    /// <summary>
    /// Velocidade Máxima em Atmosfera
    /// </summary>
    [JsonPropertyName("max_atmosphering_speed")]
    public string? MaxSpeedAtmosphering { get; set; }
    public string? Crew { get; set; }
    public string? Passengers { get; set; }

    [JsonPropertyName("cargo_capacity")]
    public string? CargoCapacity { get; set; }
    public string? Consumables { get; set; }

    [JsonPropertyName("_class")]
    public string? Class { get; set; }
    public List<string>? films { get; set; }
    public List<MovieViewModel>? Movies { get; set; }
    public List<string>? Pilots { get; set; }
    public List<CharacterViewModel>? PilotsVM { get; set; }
}
