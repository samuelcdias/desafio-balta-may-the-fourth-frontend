using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

namespace Staris.Shared.Components.Code;

public abstract class ComponentBaseGeneric<T>: ComponentBase 
{
    [Parameter]
    public T? Model { get; set; }

    public bool IsDone { get; set; }
}
