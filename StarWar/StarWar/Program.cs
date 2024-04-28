using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Staris.Shared.Configurations;
using Staris.Shared.Services;
using Staris.Shared.Services.Interfaces;
using StarWar;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#region HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Configuration.BaseUri) });
#endregion

#region IOCs
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IPeopleService, PeopleService>();
builder.Services.AddScoped<IStarshipService, StarshipService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<ISpecieService, SpecieService>();
builder.Services.AddScoped<IPlanetService, PlanetService>();
#endregion

await builder.Build().RunAsync();


