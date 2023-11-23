using AutoMapper;
using Axity.DataAccessEntity.DataAccess.DAO.Interface;
using Axity.DataAccessEntity.DataAccess.DAO.User;
using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Entities.Model.User;
using Axity.DataAccessEntity.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Services.User
{
    public class UserService : ICatalogService<UserDto>
    {
        private readonly ICatalogDao<UserModel> modelDao;
        private readonly IMapper mapper;

        public UserService(ICatalogDao<UserModel> modelDao, IMapper mapper)
        {
            this.modelDao = modelDao;
            this.mapper = mapper;
        }

        public Task Create(UserDto model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserDto model)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
