using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.Movies;

public class IndexFilm: ComponentBaseGeneric<List<MovieViewModel>>
{
    [Inject]
    public IMovieService _service { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        Model = new();
        IsDone = false;
        try
        {
            Model = await _service.GetList(1,6);
            IsDone = true;
        }
        catch(Exception ex)
        {
            //Apenas para o debug
            _= ex.Message;
        }
    }


}
