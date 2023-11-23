
namespace Axity.DataAccessEntity.DataAccess.DAO.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICatalogDao<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> FindById(int id);
        Task Create(T model);
        Task Update(T model);
        Task Delete(T model);        
    }
}
