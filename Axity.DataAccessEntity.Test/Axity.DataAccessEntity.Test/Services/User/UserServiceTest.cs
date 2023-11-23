namespace Axity.DataAccessEntity.Test.Services.User
{
    using AutoMapper;
    using Axity.DataAccessEntity.DataAccess.DAO.Interface;
    using Axity.DataAccessEntity.DataAccess.DAO.User;
    using Axity.DataAccessEntity.Dtos.User;
    using Axity.DataAccessEntity.Entities.Context;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Axity.DataAccessEntity.Resources.Exceptions;
    using Axity.DataAccessEntity.Services.Interface;
    using Axity.DataAccessEntity.Services.Mapping;
    using Axity.DataAccessEntity.Services.User;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;

    [TestFixture]
    public class UserServiceTest : BaseUserServiceTest
    {
        private ICatalogDao<UserModel> modelDao;
        private ICatalogService<UserDto> modelService;
        private DatabaseContext databaseContext;


        [OneTimeSetUp]
        public void Setup()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = configuration.CreateMapper();
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(databaseName: "Temp-User").Options;
            this.databaseContext = new DatabaseContext(options);
            this.databaseContext.Users.AddRange(UserTable());
            this.databaseContext.UserRols.AddRange(UserRolTable());
            this.databaseContext.Rols.AddRange(RolTable());
            this.databaseContext.SaveChanges();
            this.modelDao = new UserDao(this.databaseContext);
            this.modelService = new UserService(this.modelDao, mapper);
        }

        [Test(Author = "Julián.Lara", Description = "Esta prueba guarda con éxito un nuevo usuario")]
        [Category("CreateUser")]
        public void CreateTest()
        {
            Assert.DoesNotThrowAsync(async () => await this.modelService.Create(UserCreated()));
        }

        /// <summary>
        /// Documentacion test.
        /// </summary>
        [Test]
        [Author("Julián.Lara")]
        [Description("Validamos que el telefono no sea correcto")]
        [Category("CreateUser")]
        public void PhoneFailedTest()
        {
            var userCreated = UserCreated();
            userCreated.Phone = "1234567801001";
            var result = Assert.ThrowsAsync<BusinessException>(async () => await this.modelService.Create(userCreated));
            Assert.AreEqual("El telefono no es correcto.", result.Message);
        }


        [Test(Author = "Julián.Lara", Description = "Esta prueba guarda con éxito un nuevo usuario")]
        [Category("CreateUser")]
        public void CreateValidateEmailTest()
        {
            var userCreated = UserCreated();
            userCreated.Mail = "Axityaxity.com";
            var result = Assert.ThrowsAsync<BusinessException>(async () => await this.modelService.Create(userCreated));
            Assert.AreEqual("No es un emil.", result.Message);
        }

        public void DeleteTest(UserDto model)
        {
            throw new NotImplementedException();
        }

       // [TestCase(12, Author = "Julián.Lara", Description = "Esta prueba guarda con éxito un nuevo usuario")]
        [Category("SearchUser")]
        public async Task FindByIdTest()
        {
            // var result = await this.modelService.FindById();
        }

        public async Task GetAllTest()
        {
            throw new NotImplementedException();
        }

        public void UpdateTest()
        {
            throw new NotImplementedException();
        }
    }
}
