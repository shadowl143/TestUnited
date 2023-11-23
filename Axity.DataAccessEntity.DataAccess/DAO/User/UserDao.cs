namespace Axity.DataAccessEntity.DataAccess.DAO.User
{
    using Axity.DataAccessEntity.DataAccess.DAO.Interface;
    using Axity.DataAccessEntity.DataAccess.Util;
    using Axity.DataAccessEntity.Entities.Context;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserDao : ICatalogDao<UserModel>
    {
        private readonly IDatabaseContext databaseContext;

        public UserDao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public Task Create(UserModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(UserModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(UserModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
