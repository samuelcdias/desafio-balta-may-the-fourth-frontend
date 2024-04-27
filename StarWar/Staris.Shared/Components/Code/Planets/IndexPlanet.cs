using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.Planets;

public class IndexPlanet: ComponentBaseGeneric<List<PlanetViewModel>>
{
    [Inject]
    public IPlanetService _service { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        IsDone = false;
        try
        {
            Model = await _service.GetList(1,6);
            IsDone = true;
        }
        catch (Exception ex) 
        {
            //Apenas para Debug
            _ = ex.Message;
        }
    }

}
