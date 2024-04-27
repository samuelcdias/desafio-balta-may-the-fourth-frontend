using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System.Net.Http.Json;
using System.Web;

namespace Staris.Shared.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _client;
        private readonly string _endpoint;
        public MovieService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri(Configuration.BaseUri);
            _endpoint = "movies/";
        }

        public async Task<List<MovieViewModel>> GetList()
        {
            var Result = await _client.GetFromJsonAsync<ResultViewModel<MovieViewModel>>(_endpoint);
            return Result?.Results ?? [];
        }
        public async Task<List<MovieViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder)
        {
            string parameters = Configuration.BuildPostParameters(search, page, perPage, sortBy, sortOrder);
            
            var Result = await _client.GetFromJsonAsync<ResultViewModel<MovieViewModel>>(_endpoint+parameters);
            return Result?.Results ?? [];
        }
        public async Task<List<MovieViewModel>> GetList(string search, int page, int perPage)
        {
            string parameters = Configuration.BuildPostParameters(search, page, perPage, "", "");

            var Result = await _client.GetFromJsonAsync<ResultViewModel<MovieViewModel>>(_endpoint + parameters);
            return Result?.Results ?? [];
        }
        public async Task<List<MovieViewModel>> GetList( int page, int perPage)
        {
            string parameters = Configuration.BuildPostParameters("", page, perPage, "", "");
            var Result = await _client.GetFromJsonAsync<ResultViewModel<MovieViewModel>>(_endpoint + parameters);
            return Result?.Results ?? [];
        }

        public async Task<MovieViewModel> GetById(int Id)
        {
            var movie = await _client.GetFromJsonAsync<MovieViewModel>(_endpoint + Id);
            return movie ?? new();
        }


        public async Task<MovieViewModel> Create()
        {
            throw new NotImplementedException();
        }

        public Task<MovieViewModel> Delete()
        {
            throw new NotImplementedException();
        }      
       

        public Task<MovieViewModel> Update()
        {
            throw new NotImplementedException();
        }
    }
}
