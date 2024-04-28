using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Staris.Shared.Configurations;
using System.Net.Http.Headers;

namespace Staris.Shared.Components.Code;

public abstract class ComponentBaseGeneric<T> : ComponentBase
{
    [Parameter]
    public T? Model { get; set; }

    public bool IsDone { get; set; }


    [Inject]
    public IJSRuntime JSRuntime { get; set; }
    protected override async void OnParametersSet()
    {
        if (!string.IsNullOrEmpty(AppConfig.BaseUri) && false)
        {
            // Verifica se há uma configuração armazenada no local storage
            if (await JSRuntime.InvokeAsync<bool>("localStorage.getItem", "BaseUri"))
            {
                AppConfig.BaseUri = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "BaseUri");
            }
            else
            {
                // Se não houver, usa a configuração padrão
                AppConfig.BaseUri = "https://staris-api.runasp.net/api/";
            }
        }
    }
}
