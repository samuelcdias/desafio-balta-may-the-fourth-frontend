using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staris.Shared.Services.Interfaces
{
    public interface IService
    {
        public Task GetList();
        public Task GetById(int id);
        public Task Create();
        public Task Update();
        public Task Delete();
    }
}
