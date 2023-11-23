using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Facade.Interface;
using Axity.DataAccessEntity.Facade.User;
using Axity.DataAccessEntity.Resources.Exceptions;
using Axity.DataAccessEntity.Services.Interface;
using Axity.DataAccessEntity.Test.Services.User;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Test.Facade.User
{
    [TestFixture]
    public class UserFacadeTest: BaseUserServiceTest
    {
        ICatalogFacade<UserDto> modelFacade;

        [OneTimeSetUp]
        public void Setup()
        {
            var mockUserService = new Mock<ICatalogService<UserDto>>();
            mockUserService.Setup(e => e.Create(It.IsAny<UserDto>())).Returns(Task.CompletedTask);
            mockUserService.Setup(e => e.Delete(It.IsAny<UserDto>())).Returns(Task.CompletedTask);
            mockUserService.Setup(e => e.Update(It.IsAny<UserDto>())).Returns(Task.CompletedTask);
            this.modelFacade = new UserFacade(mockUserService.Object);

        }


        [Test(Author = "Julián.Lara", Description = "Esta prueba guarda con éxito un nuevo usuario")]
        [Category("CreateUser")]
        public void CreateTest()
        {
            Assert.DoesNotThrowAsync(async () => await this.modelFacade.Create(UserCreated()));
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

        public void UpdateTest(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
