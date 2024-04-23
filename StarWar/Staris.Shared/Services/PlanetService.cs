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
        _endPoint = "planets";
    }

    public async Task<List<PlanetViewModel>> GetList()
    {
        var ResultBase = await _client.GetFromJsonAsync<ResultViewModel<PlanetViewModel>>(_endPoint);
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
