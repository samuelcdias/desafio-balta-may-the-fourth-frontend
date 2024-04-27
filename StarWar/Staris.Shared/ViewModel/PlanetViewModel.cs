using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;
public class PlanetViewModel : ViewModelBase
{

    public string? Name { get; set; }
    /// <summary>
    /// O número de horas padrão que este planeta leva para completar uma única rotação em seu eixo.
    /// </summary>
    [JsonPropertyName("rotationSpeed")]
    public string? RotationPeriod { get; set; }

    /// <summary>
    /// O número de dias padrão que este planeta leva para completar uma única órbita de sua estrela local.
    /// </summary>
    public string? OrbitalPeriod { get; set; }
    public string? Diameter { get; set; }
    public string? Climate { get; set; }
    public string? Gravity { get; set; }
    public string? Terrain { get; set; }
    public string? SurfaceWater { get; set; }
    public string? Population { get; set; }
    public List<BaseToListViewModel>? Characters { get; set; }
    public List<CharacterViewModel>? CharactersVM { get; set; }
    public List<BaseToListViewModel>? Movies { get; set; }
    public List<MovieViewModel>? MoviesVM { get; set; }
}


