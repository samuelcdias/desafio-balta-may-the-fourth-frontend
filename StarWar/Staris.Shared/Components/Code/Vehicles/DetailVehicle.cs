using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.Vehicles;

public class DetailVehicle : ComponentBaseGeneric<VehicleViewModel>
{
    [EditorRequired]
    [Parameter]
    public int Id { get; set; }

    [Inject]
    public IVehicleService _service { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        IsDone = false;
        try
        {
            Model = await _service.GetById(Id);
            IsDone = true;
        }
        catch { }
    }

}
