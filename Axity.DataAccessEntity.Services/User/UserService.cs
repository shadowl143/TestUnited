using AutoMapper;
using Axity.DataAccessEntity.DataAccess.DAO.Interface;
using Axity.DataAccessEntity.DataAccess.DAO.User;
using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Entities.Model.User;
using Axity.DataAccessEntity.Resources.Contansts;
using Axity.DataAccessEntity.Resources.Exceptions;
using Axity.DataAccessEntity.Resources.Util;
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

        public async Task Create(UserDto model)
        {
            var userModel = this.mapper.Map<UserModel>(model);
            await this.CreateUserModel(userModel);
            await this.modelDao.Create(userModel);
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

        public async Task Update(UserDto model)
        {
            var userModel = this.mapper.Map<UserModel>(model);
            await this.CreateUserModel(userModel);
        }

        protected async Task CreateUserModel(UserModel userModel)
        {
            userModel.UserName = ValidateStringUtil.MatchTwoWord(userModel.Mail, userModel.UserName);
            ValidateStringUtil.ValdateWordContain(userModel.Mail, "@", "No es un emil.");
            ValidateStringUtil.ValidateLengthWord(userModel.Phone, 10, "El telefono no es correcto.");
        }
    }
}
