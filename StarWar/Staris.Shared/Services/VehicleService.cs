using Staris.Shared.Configurations;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;
using System.Net.Http.Json;

namespace Staris.Shared.Services;

public class VehicleService : IVehicleService
{
    private readonly HttpClient _client;
    private readonly string _endPoint;

    public VehicleService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri(AppConfig.BaseUri);
        _endPoint = "vehicles/";
    }

    public async Task<ResultViewModel<VehicleViewModel>> GetList()
    {
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<VehicleViewModel>>(_endPoint);
        return resultBase ?? new ResultViewModel<VehicleViewModel>();

    }
    public async Task<ResultViewModel<VehicleViewModel>> GetList(int page, int perPage)
    {
        string parameters = AppConfig.BuildPostParameters("", page, perPage, "", "");
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<VehicleViewModel>>(_endPoint + parameters);
        return resultBase ?? new ResultViewModel<VehicleViewModel>();
    }
    public async Task<ResultViewModel<VehicleViewModel>> GetList(string search, int page, int perPage)
    {
        string parameters = AppConfig.BuildPostParameters(search, page, perPage, "", "");
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<VehicleViewModel>>(_endPoint + parameters);
        return resultBase ?? new ResultViewModel<VehicleViewModel>();
    }
    public async Task<ResultViewModel<VehicleViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder)
    {
        string parameters = AppConfig.BuildPostParameters(search, page, perPage, sortBy, sortOrder);
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<VehicleViewModel>>(_endPoint + parameters);
        return resultBase ?? new ResultViewModel<VehicleViewModel>();
    }
    
    public async Task<VehicleViewModel> GetById(int id)
    {
        var vehicle = await _client.GetFromJsonAsync<VehicleViewModel>(_endPoint + id);
        return vehicle ?? new();
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
