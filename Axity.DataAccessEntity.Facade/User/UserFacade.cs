using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Facade.Interface;
using Axity.DataAccessEntity.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Facade.User
{
    public class UserFacade : ICatalogFacade<UserDto>
    {
        private readonly ICatalogService<UserDto> modelService;

        public UserFacade(ICatalogService<UserDto> modelService)
        {
            this.modelService = modelService;
        }

        public Task Create(UserDto model)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(UserDto model)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDto> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(UserDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}
