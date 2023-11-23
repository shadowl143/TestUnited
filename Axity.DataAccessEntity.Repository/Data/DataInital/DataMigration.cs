using Axity.DataAccessEntity.Entities.Model.Actions;
using Axity.DataAccessEntity.Entities.Model.Menu;
using Axity.DataAccessEntity.Entities.Model.Rols;
using Axity.DataAccessEntity.Entities.Model.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Axity.DataAccessEntity.Entities.Data.DataInital
{
    public static class DataMigration
    {
        public static void Setup(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(UserTable());
            modelBuilder.Entity<RolModel>().HasData(RolTable());
            modelBuilder.Entity<UserRolModel>().HasData(UserRolTable());
            modelBuilder.Entity<MenuModel>().HasData(MenuTable());
            modelBuilder.Entity<SubMenuModel>().HasData(SubMenuTable());
            modelBuilder.Entity<PageModel>().HasData(PageTable());
            modelBuilder.Entity<ActionModel>().HasData(ActionTable());
            modelBuilder.Entity<ActSubPageModel>().HasData(ActSubPageTable());
        }

        public static List<UserModel> UserTable()
        {
            var list = new List<UserModel>
            {
                new UserModel
                {
                    Id = 1,
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
                    Id = 2,
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
        public static List<MenuModel> MenuTable()
        {
            var list = new List<MenuModel>()
            {
                new MenuModel
                {
                    Id= 1,
                    Code = "menu",
                    Name = "menu",
                    Icon = "menu",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 2,
                    Code = "menu 1",
                    Name = "menu 1",
                    Icon = "menu 1",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 3,
                    Code = "menu 2",
                    Name = "menu 2",
                    Icon = "menu 2",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 4,
                    Code = "menu 3",
                    Name = "menu 3",
                    Icon = "menu 3",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 5,
                    Code = "menu 4",
                    Name = "menu 4",
                    Icon = "menu 4",
                    Status = true,
                },
            };

            return list;
        }
        public static List<SubMenuModel> SubMenuTable()
        {
            var list = new List<SubMenuModel>()
            {
                new SubMenuModel
                {
                    Id= 1,
                    Code = "submenu",
                    Name = "submenu",
                    Icon = "submenu",
                    MenuId = 1,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 2,
                    Code = "submenu 1",
                    Name = "submenu 1",
                    Icon = "submenu 1",
                    MenuId = 1,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 3,
                    Code = "submenu 4",
                    Name = "submenu 4",
                    Icon = "submenu 4",
                    MenuId = 2,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 4,
                    Code = "submenu 5",
                    Name = "submenu 5",
                    Icon = "submenu 5",
                    MenuId = 2,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 5,
                    Code = "submenu 6",
                    Name = "submenu 6",
                    Icon = "submenu 6",
                    MenuId = 3,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 6,
                    Code = "submenu 7",
                    Name = "submenu 7",
                    Icon = "submenu 7",
                    MenuId = 3,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 7,
                    Code = "submenu 8",
                    Name = "submenu 8",
                    Icon = "submenu 8",
                    MenuId = 4,
                    Status = true,
                },
                new SubMenuModel
                {
                    Id= 8,
                    Code = "submenu 9",
                    Name = "submenu 9",
                    Icon = "submenu 9",
                    MenuId = 5,
                    Status = true,
                },
            };

            return list;
        }
        public static List<PageModel> PageTable()
        {
            var list = new List<PageModel>()
            {
                new PageModel
                {
                    Id= 1,
                    Code = "page",
                    Name = "page",
                    Icon = "page",
                    SubMenuId = 4,
                    Status = true,
                },
                new PageModel
                {
                    Id= 2,
                    Code = "page 1",
                    Name = "page 1",
                    Icon = "page 1",
                    SubMenuId = 4,
                    Status = true,
                },
                new PageModel
                {
                    Id= 3,
                    Code = "page 2",
                    Name = "page 2",
                    Icon = "page 2",
                    SubMenuId = 4,
                    Status = true,
                },
                new PageModel
                {
                    Id= 4,
                    Code = "page 5",
                    Name = "page 5",
                    Icon = "page 5",
                    SubMenuId = 4,
                    Status = true,
                },
                new PageModel
                {
                    Id= 5,
                    Code = "page 6",
                    Name = "page 6",
                    Icon = "page 6",
                    SubMenuId = 4,
                    Status = true,
                },
                new PageModel
                {
                    Id= 6,
                    Code = "page 7",
                    Name = "page 7",
                    Icon = "page 7",
                    SubMenuId = 4,
                    Status = true,
                },
            };
            return list;
        }
        public static List<ActionModel> ActionTable()
        {
            var list = new List<ActionModel>()
            {
                new ActionModel
                {
                    Id= 1,
                    Name = "Alta",
                },
                new ActionModel
                {
                    Id= 2,
                    Name = "Baja",
                },
                new ActionModel
                {
                    Id= 3,
                    Name = "Cambios",
                },
                new ActionModel
                {
                    Id= 4,
                    Name = "Actualizar",
                },
            };
            return list;
        }
        public static List<ActSubPageModel> ActSubPageTable()
        {
            var list = new List<ActSubPageModel>()
            {
                new ActSubPageModel
                {
                    Id= 1,
                    ActionId= 1,
                    SubMenuId = 1,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 2,
                    ActionId= 2,
                    SubMenuId = 1,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 3,
                    ActionId= 3,
                    SubMenuId = 1,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 4,
                    ActionId= 4,
                    SubMenuId = 1,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 5,
                    ActionId= 1,
                    SubMenuId = 2,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 6,
                    ActionId= 2,
                    SubMenuId = 2,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 7,
                    ActionId= 3,
                    SubMenuId = 2,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 8,
                    ActionId= 4,
                    SubMenuId = 2,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 9,
                    ActionId= 1,
                    SubMenuId = 3,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 10,
                    ActionId= 3,
                    SubMenuId = 3,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 11,
                    ActionId= 1,
                    SubMenuId = 4,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 12,
                    ActionId= 2,
                    SubMenuId = 4,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 13,
                    ActionId= 3,
                    SubMenuId = 4,
                    FkPage = null,
                },
                new ActSubPageModel
                {
                    Id= 14,
                    ActionId= 4,
                    SubMenuId = 4,
                    FkPage = null,
                },

                new ActSubPageModel
                {
                    Id= 15,
                    ActionId= 1,
                    SubMenuId = null,
                    FkPage = 1,
                },
                new ActSubPageModel
                {
                    Id= 16,
                    ActionId= 2,
                    SubMenuId = null,
                    FkPage = 1,
                },
                new ActSubPageModel
                {
                    Id= 17,
                    ActionId= 3,
                    SubMenuId = null,
                    FkPage = 1,
                },
                new ActSubPageModel
                {
                    Id= 18,
                    ActionId= 1,
                    SubMenuId = null,
                    FkPage = 2,
                },
                new ActSubPageModel
                {
                    Id= 19,
                    ActionId= 2,
                    SubMenuId = null,
                    FkPage = 2,
                },
                new ActSubPageModel
                {
                    Id= 20,
                    ActionId= 3,
                    SubMenuId = null,
                    FkPage = 2,
                },
                new ActSubPageModel
                {
                    Id= 21,
                    ActionId= 4,
                    SubMenuId = null,
                    FkPage = 2,
                },


                new ActSubPageModel
                {
                    Id= 22,
                    ActionId= 1,
                    SubMenuId = null,
                    FkPage = 3,
                },
                new ActSubPageModel
                {
                    Id= 23,
                    ActionId= 2,
                    SubMenuId = null,
                    FkPage = 3,
                },

                new ActSubPageModel
                {
                    Id= 24,
                    ActionId= 2,
                    SubMenuId = null,
                    FkPage = 4,
                },
                new ActSubPageModel
                {
                    Id= 25,
                    ActionId= 3,
                    SubMenuId = null,
                    FkPage = 4,
                },
                new ActSubPageModel
                {
                    Id= 26,
                    ActionId= 4,
                    SubMenuId = null,
                    FkPage = 4,
                },
            };

            return list;
        }
    }
}
