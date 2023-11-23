// <summary>
// <copyright file="IDatabaseContext.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.Entities.Context
{
    using Axity.DataAccessEntity.Entities.Model.Actions;
    using Axity.DataAccessEntity.Entities.Model.Menu;
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;
    using System;

    /// <summary>
    /// Interface IDataBaseContext.
    /// </summary>
    public interface IDatabaseContext
    {

        DbSet<UserModel> Users { get; set; }
        DbSet<RolModel> Rols { get; set; }
        DbSet<UserRolModel> UserRols { get; set; }
        DbSet<MenuModel> Menus { get; set; }
        DbSet<SubMenuModel> subMenus { get; set; }
        DbSet<PageModel> Pages { get; set; }
        DbSet<ActionModel> Actions { get; set; }
        DbSet<ActSubPageModel> ActionSubPage { get; set; }
    }
}
