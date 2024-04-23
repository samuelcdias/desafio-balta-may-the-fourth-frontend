﻿using Staris.Shared.Configurations;
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
        return starShips != null ? starShips.Results : [];
    }
    public async Task<StarshipViewModel> GetById(int Id)
    {
        var starship = await _client.GetFromJsonAsync<StarshipViewModel>(_endPoint + Id);
        return starship != null ? starship : new();
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