using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System.Globalization;
using System.Net.Http.Json;

namespace Staris.Shared.Services;

public class PeopleService : IPeopleService
{
    private readonly HttpClient _client;
    private readonly string _endpoint;
    public PeopleService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri(Configuration.BaseUri);
        //_client = httpClientFactory.CreateClient(Configuration.HttpClientName);

        //_endpoint = "people/";
        _endpoint = "characters/";
       
    }
    public async Task<List<CharacterViewModel>> GetList()
    {
        var peoples = await _client.GetFromJsonAsync<ResultViewModel<CharacterViewModel>>(_endpoint);
        return peoples?.Results ?? [];
    }
    public async Task<List<CharacterViewModel>> GetList(int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters("", page, perPage,"","");
        var peoples = await _client.GetFromJsonAsync<ResultViewModel<CharacterViewModel>>(_endpoint + parameters);
        return peoples?.Results ?? [];
    }
    public async Task<List<CharacterViewModel>> GetList(string search, int page, int perPage)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, "","");
        var peoples = await _client.GetFromJsonAsync<ResultViewModel<CharacterViewModel>>(_endpoint + parameters);
        return peoples?.Results ?? [];
    }
    public async Task<List<CharacterViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder)
    {
        string parameters = Configuration.BuildPostParameters(search, page, perPage, sortBy, sortOrder);
        var peoples = await _client.GetFromJsonAsync<ResultViewModel<CharacterViewModel>>(_endpoint + parameters);
        return peoples?.Results ?? [];
    }

    public async Task<CharacterViewModel> GetById(int Id)
    {
        var people = await _client.GetFromJsonAsync<CharacterViewModel>(_endpoint + Id);
        return people ?? new();
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
