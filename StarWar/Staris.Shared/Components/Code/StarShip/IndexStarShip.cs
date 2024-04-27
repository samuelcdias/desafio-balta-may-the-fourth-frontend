using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.StarShip;

public class IndexStarShip: ComponentBaseGeneric<List<StarshipViewModel>>
{
    [Inject]
    public IStarshipService _service { get; set; } = null!;

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
            //para debug
            _=ex.Message;
        }

    }

}
