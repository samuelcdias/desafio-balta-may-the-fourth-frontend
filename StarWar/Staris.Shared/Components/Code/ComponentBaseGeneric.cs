using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

namespace Staris.Shared.Components.Code;

public class ComponentBaseGeneric<T>: ComponentBase 
{
    [Parameter]
    public T Model { get; set; }
    [Parameter]
    public int TotalPages { get; set; }
    public int CurrentPage { get; set; } = 1;


    public bool IsDone { get; set; }
}
