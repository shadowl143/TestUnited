using Axity.DataAccessEntity.Entities.Model.Rols;
using Microsoft.EntityFrameworkCore;

namespace Axity.DataAccessEntity.Entities.Data.Constraint
{
    public static class RolConstraint
    {
        public static void Init(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolModel>().Property(e=>e.Name).HasMaxLength(100).IsUnicode(true);
            modelBuilder.Entity<RolModel>().Property(e=>e.Code).HasMaxLength(20).IsUnicode(true);
            modelBuilder.Entity<RolModel>().Property(e=>e.Description).HasMaxLength(150).IsUnicode(true);
        }
    }
}
