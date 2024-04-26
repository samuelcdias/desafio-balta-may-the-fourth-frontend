using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System.Net.Http.Json;

namespace Staris.Shared.Services;

public class PlanetService : IPlanetService
{
    private readonly HttpClient _client;
    private readonly string _endPoint;

    public PlanetService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri(Configuration.BaseUri);
        _endPoint = "planets/";
    }

    public async Task<List<PlanetViewModel>> GetList()
    {
        var ResultBase = await _client.GetFromJsonAsync<ResultViewModel<PlanetViewModel>>(_endPoint);
        return ResultBase?.Results ?? [];
    }
    public async Task<List<PlanetViewModel>> GetList(int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters("", page, perPage, "", "");
        var ResultBase = await _client.GetFromJsonAsync<ResultViewModel<PlanetViewModel>>(_endPoint + parameters);
        return ResultBase?.Results ?? [];
    }
    public async Task<List<PlanetViewModel>> GetList(string search, int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, "", "");
        var ResultBase = await _client.GetFromJsonAsync<ResultViewModel<PlanetViewModel>>(_endPoint + parameters);
        return ResultBase?.Results ?? [];
    }
    public async Task<List<PlanetViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, sortBy, sortOrder);
        var ResultBase = await _client.GetFromJsonAsync<ResultViewModel<PlanetViewModel>>(_endPoint + parameters);
        return ResultBase?.Results ?? [];
    }

    public async Task<PlanetViewModel> GetById(int Id)
    {
        var planet = await _client.GetFromJsonAsync<PlanetViewModel>(_endPoint+Id);
        return planet ?? new();
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
