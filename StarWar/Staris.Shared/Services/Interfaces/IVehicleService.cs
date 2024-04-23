using Staris.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staris.Shared.Services.Interfaces
{
    public interface IVehicleService
    {
        /// <summary>
        /// Retorna Lista de Veículos
        /// </summary>
        /// <returns></returns>
        public Task<List<VehicleViewModel>> GetList();
        /// <summary>
        /// Retorna Veiculo pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<VehicleViewModel> GetById(int id);
        /// <summary>
        /// Criar Veículo
        /// </summary>
        /// <returns></returns>
        public Task Create();
        /// <summary>
        /// Alterar Veículo
        /// </summary>
        /// <returns></returns>
        public Task Update();
        /// <summary>
        /// Deletar Veículo
        /// </summary>
        /// <returns></returns>
        public Task Delete();

    }
}
