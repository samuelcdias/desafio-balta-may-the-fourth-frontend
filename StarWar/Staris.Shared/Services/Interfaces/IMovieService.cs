using Staris.Shared.ViewModel;
namespace Staris.Shared.Services.Interfaces;

public interface IMovieService
{
    /// <summary>
    /// Retorna Lista de Filme
    /// </summary>
    /// <returns></returns>
    public Task<List<MovieViewModel>> GetList();
    public Task<List<MovieViewModel>> GetList(int page, int perPage);
    public Task<List<MovieViewModel>> GetList(string search, int page, int perPage);
    public Task<List<MovieViewModel>> GetList(string search, int page, int perPage, string sortBy, string sortOrder);
    

    /// <summary>
    /// Retorna único Filme pelo código
    /// </summary>
    /// <returns></returns>
    public Task<MovieViewModel> GetById(int Id);
    /// <summary>
    /// Craiar Filme
    /// </summary>
    /// <returns></returns>
    public Task<MovieViewModel> Create();
    /// <summary>
    /// Alterar Filme
    /// </summary>
    /// <returns></returns>
    public Task<MovieViewModel> Update();
    /// <summary>
    /// Deletar Filme
    /// </summary>
    /// <returns></returns>
    public Task<MovieViewModel> Delete();




}
