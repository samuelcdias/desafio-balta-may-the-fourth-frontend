using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.Movies;

public class IndexFilm: ComponentBaseGeneric<List<MovieViewModel>>
{
    [Inject]
    public IMovieService _service { get; set; } = null!;
    [Inject]
    public NavigationManager _navigationManager { get; set; } = default!;
    [Parameter]
    [SupplyParameterFromQuery]
    public int Page { get; set; } = 1;
    [Parameter]
    public int TotalPages { get; set; } = 1;

    protected override async Task OnInitializedAsync()
    {
        await GetModel();
    }

    protected override async Task OnParametersSetAsync()
    {
        await GetModel();
    }
    protected async Task GetModel()
    {
        IsDone = false;

        try
        {
            var response = await _service.GetList(Page, 6);
            Model = response.Results;
            TotalPages = response.TotalPages;

            IsDone = true;
        }
        catch (Exception ex)
        {
            //Apenas para o debug
            _ = ex.Message;
        }
    }
   


}
