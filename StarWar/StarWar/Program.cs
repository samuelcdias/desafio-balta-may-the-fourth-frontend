using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Staris.Shared.Configurations;
using Staris.Shared.Services;
using Staris.Shared.Services.Interfaces;
using StarWar;
using StarWar.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.TryAddTransient(sp => new HttpClient
{ BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddHttpClient(Configuration.HttpClientName,
//    x =>
//    {
//        x.BaseAddress = new Uri(Configuration.BaseUri);
//    });
//builder.Services.AddTransient<TestePessoa>();

builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IPeopleService, PeopleService>();
builder.Services.AddTransient<IStarshipService, StarshipService>();
builder.Services.AddTransient<IVehicleService, VehicleService>();
builder.Services.AddTransient<ISpecieService, SpecieService>();
builder.Services.AddTransient<IPlanetService, PlanetService>();

await builder.Build().RunAsync();


