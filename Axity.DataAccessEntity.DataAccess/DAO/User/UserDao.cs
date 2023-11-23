namespace Axity.DataAccessEntity.DataAccess.DAO.User
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessEntity.DataAccess.DAO.Interface;
    using Axity.DataAccessEntity.Entities.Context;
    using Axity.DataAccessEntity.Entities.Model.User;

    public class UserDao : ICatalogDao<UserModel>
    {
        private readonly IDatabaseContext databaseContext;

        public UserDao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public async Task Create(UserModel model)
        {
            this.databaseContext.Users.Add(model);
            await ((DatabaseContext)this.databaseContext).SaveChangesAsync();
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
