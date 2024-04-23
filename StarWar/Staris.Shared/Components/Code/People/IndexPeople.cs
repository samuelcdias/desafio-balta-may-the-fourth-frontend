using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.People;

public class IndexPeople: ComponentBaseGeneric<List<CharacterViewModel>>
{
    [Inject]
    public IPeopleService _service { get; set; }

    protected override async Task OnInitializedAsync()
    {
        IsDone = false;
        try
        {
            Model = await _service.GetList();
            IsDone = true;
        }
        catch(Exception ex)
        {
            //apenas para debug
            _=ex.Message;
        }
    }

}
