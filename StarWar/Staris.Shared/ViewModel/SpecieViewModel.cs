using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public class SpecieViewModel: ViewModelBase
{
    public string? Name { get; set; }
    public string? Classification { get; set; }
    public string? Designation { get; set; }
    /// <summary>
    /// Altura média em centimetros
    /// </summary>
    [JsonPropertyName("average_height")]
    public string? AverageHeight { get; set; }
    /// <summary>
    /// Expectativa média em anos
    /// </summary>
    [JsonPropertyName("average_lifespan")]
    public string? AverageLifespan { get; set; }

    [JsonPropertyName("eye_colors")]
    public string? EyeColors { get; set; }

    [JsonPropertyName("hair_colors")]
    public string? HairColors { get; set; }

    [JsonPropertyName("skin_colors")]
    public string? SkinColors { get; set; }
    public string? Language { get; set; }
    /// <summary>
    /// Planeta natal
    /// </summary>
    public string? Homeworld { get; set; }
    public List<string>? People { get; set; }
    public List<CharacterViewModel>? PeopleVM { get; set; }
    public List<string>? Films { get; set; }
    public List<MovieViewModel>? FilmsVM { get; set; }











}
