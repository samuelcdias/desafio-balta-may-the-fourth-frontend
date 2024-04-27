using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.StarShip;

public class DetailStarShip: ComponentBaseGeneric<StarshipViewModel>
{
    [EditorRequired]
    [Parameter]
    public int Id { get; set; }

    [Inject]
    public IStarshipService _service { get; set; } = null!;

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
