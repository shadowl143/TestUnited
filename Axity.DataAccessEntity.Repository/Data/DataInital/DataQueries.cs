using Axity.DataAccessEntity.Entities.Context;
using Axity.DataAccessEntity.Entities.Model.Actions;
using Axity.DataAccessEntity.Entities.Model.Menu;
using Axity.DataAccessEntity.Entities.Model.Rols;
using Axity.DataAccessEntity.Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Entities.Data.DataInital
{
    public class DataQueries
    {
        private readonly IDatabaseContext databaseContext;

        public DataQueries(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
            this.UserTable();
        }
        public static void Setup()
        {

        }

        public void UserTable()
        {
            var exist = this.databaseContext.Users.Any();
            if (!exist)
            {
                var list = new List<UserModel>
                {
                    new UserModel
                    {
                        LastName = "Last",
                        Mail = "Mail",
                        Name = "Name",
                        Password = "Password",
                        Phone = "123456789",
                        RegisterDate = new DateTime(2023, 11, 20),
                        SecondLastName = "SecondLastName",
                        Status = true,
                        UserName = "Mail",
                    },
                    new UserModel
                    {
                        LastName = "user1",
                        Mail = "user1",
                        Name = "user1",
                        Password = "user1",
                        Phone = "123456788",
                        RegisterDate = new DateTime(2023, 11, 20),
                        SecondLastName = "user1",
                        Status = true,
                        UserName = "user1",
                    },
                };
                this.databaseContext.Users.AddRange(list);
                ((DatabaseContext)this.databaseContext).SaveChanges();
            }
        }
    }
}
