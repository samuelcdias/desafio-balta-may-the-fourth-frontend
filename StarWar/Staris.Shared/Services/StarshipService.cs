using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System.Net.Http.Json;

namespace Staris.Shared.Services;

public class StarshipService : IStarshipService
{
    private readonly HttpClient _client;
    private readonly string _endPoint;

    public StarshipService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri(Configuration.BaseUri);
        _endPoint = "starships/";
    }
    public async Task<List<StarshipViewModel>> GetList()
    {
        var starShips = await _client.GetFromJsonAsync<ResultViewModel<StarshipViewModel>>(_endPoint);
        return starShips?.Results ?? [];
    }
    public async Task<List<StarshipViewModel>> GetList(int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters("", page, perPage, "","");
        var starShips = await _client.GetFromJsonAsync<ResultViewModel<StarshipViewModel>>(_endPoint + parameters);
        return starShips?.Results ?? [];
    }
    public async Task<List<StarshipViewModel>> GetList(string search, int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, "", "");
        var starShips = await _client.GetFromJsonAsync<ResultViewModel<StarshipViewModel>>(_endPoint + parameters);
        return starShips?.Results ?? [];
    }
    public async Task<List<StarshipViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, sortBy, sortOrder);
        var starShips = await _client.GetFromJsonAsync<ResultViewModel<StarshipViewModel>>(_endPoint + parameters);
        return starShips?.Results ?? [];
    }

    public async Task<StarshipViewModel> GetById(int Id)
    {
        var starship = await _client.GetFromJsonAsync<StarshipViewModel>(_endPoint + Id);
        return starship ?? new();
    }
    public Task Create()
    {
        throw new NotImplementedException();
    }

    public Task Delete()
    {
        throw new NotImplementedException();
    }

    

    public Task Update()
    {
        throw new NotImplementedException();
    }
}
