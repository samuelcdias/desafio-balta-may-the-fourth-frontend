using Staris.Shared.Components.Code;
using Staris.Shared.ViewModel;
using System.Net.Http.Json;

namespace Staris.Shared.Components.Code.Movies;

public class Film : ComponentBaseGeneric<MovieViewModel>
{

    public bool IsDoneCharacters { get; set; } = false;
    public string Erro { get; set; }

    //protected override async Task OnInitializedAsync()
    //{
    //    IsDoneCharacters = false;
    //    Model.CharactersVM = new();
    //    try
    //    {
    //        for (int i = 0; i < Model.Characters.Count; i++)
    //        {
    //            string endPoint = Model.Characters[i];
    //            var resp = await _client.GetAsync(endPoint);
    //            if (resp.IsSuccessStatusCode)
    //            {
    //                var person = await resp.Content.ReadFromJsonAsync<CharacterViewModel>();
    //                if (person is not null)
    //                    Model.CharactersVM.Add(person);
    //            }
    //        }
    //        IsDoneCharacters = true; ;
    //    }
    //    catch (Exception ex)
    //    {
    //        Erro = ex.Message;
    //        IsDoneCharacters = false;
    //    }

    //}


}
