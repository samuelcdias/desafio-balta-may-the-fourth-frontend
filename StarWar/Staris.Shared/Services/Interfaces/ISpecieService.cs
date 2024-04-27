using Staris.Shared.ViewModel;

namespace Staris.Shared.Services.Interfaces;

public interface ISpecieService
{
    /// <summary>
    /// Retorna Lista de Espécies
    /// </summary>
    /// <returns></returns>
    public Task<List<SpecieViewModel>> GetList();
    public Task<List<SpecieViewModel>> GetList(int page, int perPage);
    public Task<List<SpecieViewModel>> GetList(string search, int page, int perPage);
    public Task<List<SpecieViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder);
    /// <summary>
    /// Retorna Specie pelo Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Task<SpecieViewModel> GetById(int Id);
    /// <summary>
    /// Cria Espécie
    /// </summary>
    /// <returns></returns>
    public Task Create();
    /// <summary>
    /// Altera Espécie
    /// </summary>
    /// <returns></returns>
    public Task Update();
    /// <summary>
    /// Deleta Espécie
    /// </summary>
    /// <returns></returns>
    public Task Delete();

}
