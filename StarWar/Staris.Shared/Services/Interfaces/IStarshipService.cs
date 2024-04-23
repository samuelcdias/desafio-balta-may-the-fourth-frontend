using Staris.Shared.ViewModel;

namespace Staris.Shared.Services.Interfaces;

public interface IStarshipService
{
    /// <summary>
    /// Retorna Lista de Naves
    /// </summary>
    /// <returns></returns>
    public Task<List<StarshipViewModel>> GetList();
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
