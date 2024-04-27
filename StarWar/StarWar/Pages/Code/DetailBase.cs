using Microsoft.AspNetCore.Components;
using Staris.Shared.Components.Code;

namespace StarWar.Pages.Code;

public class DetailBase: ComponentBase
{
    [Parameter]
    public int Id { get; set; }
}
