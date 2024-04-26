using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.Planets;

public class DetailPlanet: ComponentBaseGeneric<PlanetViewModel>
{
    [EditorRequired]
    [Parameter]
    public int Id{ get; set; }

    [Inject]
    public IPlanetService _service { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        IsDone = false;
        try
        {
            Model = await _service.GetById(Id);
            IsDone = true;
        }
        catch(Exception ex) 
        {
            _ = ex.Message;
        }
    }

}
