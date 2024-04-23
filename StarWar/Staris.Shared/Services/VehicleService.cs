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
        _client.BaseAddress = new Uri(Configuration.BaseUri);
        _endPoint = "vehicles/";
    }

    public async Task<List<VehicleViewModel>> GetList()
    {
        var resultBase = await _client.GetFromJsonAsync<ResultViewModel<VehicleViewModel>>(_endPoint);
        return resultBase?.Results ?? [];

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
