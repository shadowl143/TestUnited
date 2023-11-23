using Axity.DataAccessEntity.Entities.Model.Menu;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Entities.Data.Constraint
{
    public static class MenuContraint
    {
        public static void Init(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuModel>().Property(e => e.Name).HasMaxLength(20);
            modelBuilder.Entity<SubMenuModel>().Property(e => e.Name).HasMaxLength(50);
            modelBuilder.Entity<PageModel>().Property(e => e.Name).HasMaxLength(50);
        }
    }
}
