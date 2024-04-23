using Staris.Shared.ViewModel;

namespace Staris.Shared.Services.Interfaces;

public interface IPlanetService
{
    /// <summary>
    /// Retorna Lista de Planetas
    /// </summary>
    /// <returns></returns>
    public Task<List<PlanetViewModel>> GetList();
    /// <summary>
    /// Retorna Planeta pelo Id
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public Task<PlanetViewModel> GetById(int Id);
    /// <summary>
    /// Cria novo Planeta
    /// </summary>
    /// <returns></returns>
    public Task Create();
    /// <summary>
    /// Altera Planeta
    /// </summary>
    /// <returns></returns>
    public Task Update();
    /// <summary>
    /// Deleta Planeta
    /// </summary>
    /// <returns></returns>
    public Task Delete();
}
