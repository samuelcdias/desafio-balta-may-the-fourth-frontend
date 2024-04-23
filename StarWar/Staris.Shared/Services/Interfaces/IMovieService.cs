using Staris.Shared.ViewModel;
namespace Staris.Shared.Services.Interfaces;

public interface IMovieService
{
    /// <summary>
    /// Retorna Lista de Filme
    /// </summary>
    /// <returns></returns>
    public Task<List<MovieViewModel>> GetList();
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
