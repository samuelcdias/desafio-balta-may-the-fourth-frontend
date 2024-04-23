using Staris.Shared.ViewModel;

namespace Staris.Shared.Services.Interfaces;

public interface IPeopleService
{
    /// <summary>
    /// Retorna Lista de Pessoas
    /// </summary>
    /// <returns></returns>
    public Task<List<CharacterViewModel>> GetList();
    /// <summary>
    /// Retorna Pessoa pelo ID
    /// </summary>
    /// <returns></returns>
    public Task<CharacterViewModel> GetById(int Id);
    /// <summary>
    /// Criar Personagem
    /// </summary>
    /// <returns></returns>
    public Task Create();
    /// <summary>
    /// Alterar Personagem
    /// </summary>
    /// <returns></returns>
    public Task Update();
    /// <summary>
    /// Deletar Personagem
    /// </summary>
    /// <returns></returns>
    public Task Delete();

}
