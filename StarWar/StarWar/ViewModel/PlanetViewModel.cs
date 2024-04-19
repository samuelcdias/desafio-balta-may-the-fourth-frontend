﻿namespace StarWars.ViewModel
{
    public class PlanetViewModel: ViewModelBase
    {
        public string? Name { get; set; }
        public string? RotationPeriod { get; set; }
        public string? OrbitalPeriod { get; set; }
        public string? Diameter { get; set; }
        public string? Climate { get; set; }
        public string? Gravity { get; set; }
        public string? Terrain { get; set; }
        public string? SurfaceWater { get; set; }
        public string? Population { get; set; }
        public List<CharacterViewModel>? Characters { get; set; }
        public List<MovieViewModel>? Movies { get; set; }
    }

}