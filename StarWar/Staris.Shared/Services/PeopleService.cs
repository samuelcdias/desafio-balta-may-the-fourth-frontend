﻿using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
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
        _endpoint = "people/";
    }
    public async Task<List<CharacterViewModel>> GetList()
    {

        var Peoples = await _client.GetFromJsonAsync<ResultViewModel<CharacterViewModel>>(_endpoint);
        return Peoples != null ? Peoples.Results : new();
    }

    public async Task<CharacterViewModel> GetById(int Id)
    {
        var People = await _client.GetFromJsonAsync<CharacterViewModel>(_endpoint + Id);
        return People != null ? People : new();
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