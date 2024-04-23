using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

namespace Staris.Shared.Components.Code;

public class ComponentBaseGeneric<T>: ComponentBase where T : class, new()
{
    //[EditorRequired]
    [Parameter]
    public string? Endpoint { get; set; }

    //[Inject]
    //public HttpClient _client{ get; set; }


    [Parameter]
    public T Model { get; set; }








}
