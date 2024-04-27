using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System.Net.Http.Json;

namespace Staris.Shared.Services;

public class SpecieService : ISpecieService
{
    private readonly HttpClient _client;
    private readonly string _endPoint;

    public SpecieService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri(Configuration.BaseUri);
        _endPoint = "species";
    }

    public async Task<List<SpecieViewModel>> GetList()
    {
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<SpecieViewModel>>(_endPoint);
        return resultBase?.Results ?? [];
    }
    public async Task<List<SpecieViewModel>> GetList(int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters("", page, perPage,"","");
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<SpecieViewModel>>(_endPoint + parameters);
        return resultBase?.Results ?? [];
    }
    public async Task<List<SpecieViewModel>> GetList(string search, int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage,"","");
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<SpecieViewModel>>(_endPoint + parameters);
        return resultBase?.Results ?? [];
    }
    public async Task<List<SpecieViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, sortBy, sortOrder);
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<SpecieViewModel>>(_endPoint + parameters);
        return resultBase?.Results ?? [];
    }

    public async Task<SpecieViewModel> GetById(int Id)
    {
        var specie = await _client.GetFromJsonAsync<SpecieViewModel>(_endPoint + Id);
        return specie ?? new();
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
