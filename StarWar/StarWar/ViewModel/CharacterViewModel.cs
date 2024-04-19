namespace StarWars.ViewModel
{
    public sealed class CharacterViewModel : ViewModelBase
    {
        public string? Name { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? HairColor { get; set; }
        public string? SkinColor { get; set; }
        public string? EyeColor { get; set; }
        public string? BirthYear { get; set; }
        public string? Gender { get; set; }
        public PlanetViewModel? Planets { get; set; }
        public List<MovieViewModel>? Movies { get; set; }
    }

}
