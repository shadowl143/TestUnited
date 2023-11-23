// <summary>
// <copyright file="DatabaseContext.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.Entities.Context
{
    using Axity.DataAccessEntity.Entities.Data.Constraint;
    using Axity.DataAccessEntity.Entities.Data.DataInital;
    using Axity.DataAccessEntity.Entities.Model.Actions;
    using Axity.DataAccessEntity.Entities.Model.Menu;
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Class DBcontext.
    /// </summary>
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseContext"/> class.
        /// </summary>
        /// <param name="options">Connection Options.</param>
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<RolModel> Rols { get; set; }
        public DbSet<UserRolModel> UserRols { get; set; }
        public DbSet<MenuModel> Menus { get; set; }
        public DbSet<SubMenuModel> subMenus { get; set; }
        public DbSet<PageModel> Pages { get; set; }
        public DbSet<ActionModel> Actions { get; set; }
        public DbSet<ActSubPageModel> ActionSubPage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConstraint.Init(modelBuilder);
            RolConstraint.Init(modelBuilder);
            MenuContraint.Init(modelBuilder);
            DataMigration.Setup(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
