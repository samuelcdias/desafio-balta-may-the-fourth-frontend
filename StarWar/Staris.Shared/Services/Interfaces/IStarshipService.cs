using Staris.Shared.ViewModel;

namespace Staris.Shared.Services.Interfaces;

public interface IStarshipService
{
    /// <summary>
    /// Retorna Lista de Naves
    /// </summary>
    /// <returns></returns>
    public Task<ResultViewModel<StarshipViewModel>> GetList();
    public Task<ResultViewModel<StarshipViewModel>> GetList(int page, int perPage);
    public Task<ResultViewModel<StarshipViewModel>> GetList(string search, int page, int perPage);
    public Task<ResultViewModel<StarshipViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder);

    /// <summary>
    /// Retorna Nave pelo ID
    /// </summary>
    /// <returns></returns>
    public Task<StarshipViewModel> GetById(int Id);
    /// <summary>
    /// Criar Nave
    /// </summary>
    /// <returns></returns>
    public Task Create();
    /// <summary>
    /// Alterar Nave
    /// </summary>
    /// <returns></returns>
    public Task Update();
    /// <summary>
    /// Deletar Nave
    /// </summary>
    /// <returns></returns>
    public Task Delete();

}
