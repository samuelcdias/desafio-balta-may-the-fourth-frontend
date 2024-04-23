using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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
            _endpoint = "films/";
        }

        public async Task<List<MovieViewModel>> GetList()
        {
            var rep = await _client.GetAsync(Configuration.BaseUri + _endpoint);
            var Result = await rep.Content.ReadFromJsonAsync<ResultViewModel<MovieViewModel>>();
            return Result != null ? Result.Results : [];
        }

        public async Task<MovieViewModel> GetById(int Id)
        {
            var Movie = await _client.GetFromJsonAsync<MovieViewModel>(_endpoint + Id);
            return Movie != null ? Movie : new();
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
