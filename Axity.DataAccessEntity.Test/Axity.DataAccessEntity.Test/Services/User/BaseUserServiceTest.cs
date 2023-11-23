using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Entities.Model.Rols;
using Axity.DataAccessEntity.Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Test.Services.User
{
    public abstract class BaseUserServiceTest
    {
        public static List<UserModel> UserTable()
        {
            var list = new List<UserModel>()
            {
                new UserModel
                {
                    Id = 1,
                    Name = "Name",
                    LastName = "Name",
                    Mail = "Name@axity.com",
                    Password = "Password",
                    Phone = "6141234567",
                    SecondLastName = "Name",
                    UserName ="Name@axity.com",
                    Status = true,
                },
                new UserModel
                {
                    Id = 2,
                    Name = "Name1",
                    LastName = "Name1",
                    Mail = "Name1@axity.com",
                    UserName = "Name1@axity.com",
                    Password = "Password1",
                    Phone = "6141234566",
                    SecondLastName = "Name1",
                    Status = true,
                },
                new UserModel
                {
                    Id = 3,
                    Name = "Name2",
                    LastName = "Name2",
                    Mail = "Name2@axity.com",
                    UserName = "Name2@axity.com",
                    Password = "Password",
                    Phone = "6141234565",
                    SecondLastName = "Name2",
                    Status = false,
                }
            };
            return list;
        }

        public static List<RolModel> RolTable()
        {
            var list = new List<RolModel>
            {
                new RolModel
                {
                    Id = 1,
                    Name = "rol",
                    Description = "rol",
                    Code = "rol",
                    Status = true,
                },
                new RolModel
                {
                    Id = 2,
                    Name = "rol1",
                    Description = "rol1",
                    Code = "rol1",
                    Status = true,
                },
            };
            return list;
        }

        public static List<UserRolModel> UserRolTable()
        {
            var list = new List<UserRolModel>()
            {
                new UserRolModel
                {
                    UserId = 1,
                    RolId = 1,
                },
                new UserRolModel
                {
                    UserId = 1,
                    RolId = 2,
                },
                new UserRolModel
                {
                    UserId = 2,
                    RolId = 1,
                },
            };
            return list;
        }

        public static UserDto UserCreated()
        {
            return new UserDto
            {
                Name = "Name10",
                LastName = "Name10",
                Mail = "Name0@axity.com",
                Password = "Password",
                Phone = "6141234599",
                SecondLastName = "Name10",
                Status = "Activo",
            };
        }

        public static UserModel UserModified()
        {
            return new UserModel
            {
                Id = 1,
                Name = "Name",
                LastName = "Name",
                Mail = "Name@axity.com",
                Password = "Password",
                Phone = "6141234567",
                SecondLastName = "Name",
                UserName = "Name@axity.com",
                Status = true,
            };
        }
    }
}
