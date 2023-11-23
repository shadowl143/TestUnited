using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Services.Interface
{
    public interface ICatalogService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> FindById(int id);
        Task Create(T model);
        Task Update(T model);
        Task Delete(T model);
    }
}
