using Microsoft.Extensions.DependencyInjection;
using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.Services;
using Microsoft.JSInterop;


namespace Staris.Shared.Extensions
{
    public static class BuilderSSRExtension
    {
        /// <summary>
        /// Injeção de dependência
        /// </summary>
        /// <param name="services">DI container</param>
        public static async Task AddIocSSR(this IServiceCollection services)
        {
          
            #region HttpClient
            var serviceProvider = services.BuildServiceProvider();
            var serviceTeemp = serviceProvider.GetRequiredService<IJSRuntime>();
            AppConfig.BaseUri = await GetBaseUriFromBrowserStorageAsync(serviceTeemp);

            services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(AppConfig.BaseUri) });
            #endregion

            #region IOCs
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IPeopleService, PeopleService>();
            services.AddTransient<IStarshipService, StarshipService>();
            services.AddTransient<IVehicleService, VehicleService>();
            services.AddTransient<ISpecieService, SpecieService>();
            services.AddTransient<IPlanetService, PlanetService>();
            #endregion
        }


        private static async Task<string> GetBaseUriFromBrowserStorageAsync(IJSRuntime jsRuntime)
        {
            try
            {
                var ret = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "BaseUri");
                return ret?? "https://staris-api.runasp.net/api/";
            }
            catch (Exception ex)
            {
               return "https://staris-api.runasp.net/api/";
            }
        }
    }


}
