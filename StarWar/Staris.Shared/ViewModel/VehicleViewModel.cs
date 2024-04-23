using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public class VehicleViewModel: ViewModelBase
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? Manufacturer { get; set; }
    public string? CostInCredits { get; set; }
    public string? Length { get; set; }
    public string? MaxSpeed { get; set; }
    public string? Crew { get; set; }
    public string? Passengers { get; set; }
    public string? CargoCapacity { get; set; }
    public string? Consumables { get; set; }
    [JsonPropertyName("_class")]
    public string? Class { get; set; }
    public List<MovieViewModel>? Movies { get; set; }
}
