using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Staris.Shared.Services;
using Staris.Shared.Services.Interfaces;
using StarWar;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.TryAddTransient(sp => new HttpClient 
{ BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IPeopleService, PeopleService>();
builder.Services.AddScoped<IStarshipService, StarshipService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<ISpecieService, SpecieService>();
builder.Services.AddScoped<IPlanetService, PlanetService>();

await builder.Build().RunAsync();


