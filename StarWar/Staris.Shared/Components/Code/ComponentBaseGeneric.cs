using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Staris.Shared.Configurations;
using System.Net;
using System.Net.Http;
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

    public static string RemoverSubstring(string texto, string substring = "/revision")
    {
        int indice = texto.IndexOf(substring);
        if (indice != -1)
        {
            // Remove a substring e tudo que vem depois dela
            return texto.Substring(0, indice);
        }
        else
        {
            // Se a substring não for encontrada, retorna o texto original
            return texto;
        }
    }

    public async Task<string> BaixarImagemParaBase64(string url)
    {
        url = RemoverSubstring(url);
        using (HttpClient webClient = new HttpClient())
        {
            byte[] imagemBytes = await webClient.GetByteArrayAsync(url);
            string contentType = webClient.DefaultRequestHeaders.Accept.ToString();
            string base64String = $"data:image/png;base64,{Convert.ToBase64String(imagemBytes)}";
            return base64String;
        }
    }
}
