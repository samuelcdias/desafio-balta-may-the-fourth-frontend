namespace StarWars.ViewModel
{
    public sealed class MovieViewModel: ViewModelBase
    {
        public string? Title { get; set; }
        public int Episode { get; set; }
        public string? OpeningCrawl { get; set; }
        public string? Director { get; set; }
        public string? Producer { get; set; }
        public string? ReleaseDate { get; set; }
        public List<CharacterViewModel>? characters { get; set; }
        public List<PlanetViewModel>? Planets { get; set; }
        public List<VehicleViewModel>? Vehicles { get; set; }
        public List<StarshipViewModel>? Starships { get; set; }

       
    }

}
