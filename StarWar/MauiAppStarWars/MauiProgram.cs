using Microsoft.Extensions.Logging;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.Services;
using Staris.Shared.Configurations;

namespace MauiAppStarWars
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif


            #region HttpClient
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(AppConfig.BaseUri) });
            #endregion
            #region IOCs
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IPeopleService, PeopleService>();
            builder.Services.AddScoped<IStarshipService, StarshipService>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();
            builder.Services.AddScoped<ISpecieService, SpecieService>();
            builder.Services.AddScoped<IPlanetService, PlanetService>();
            #endregion

            return builder.Build();
        }
    }
}
