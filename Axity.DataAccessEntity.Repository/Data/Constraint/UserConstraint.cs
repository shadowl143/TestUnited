using Axity.DataAccessEntity.Entities.Model.User;
using Microsoft.EntityFrameworkCore;

namespace Axity.DataAccessEntity.Entities.Data.Constraint
{
    public static class UserConstraint
    {
        public static void Init(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().Property(e => e.Mail).IsUnicode(true);
            modelBuilder.Entity<UserModel>().Property(e => e.Phone).HasAnnotation("MaxLength", 10).IsUnicode(true);
            modelBuilder.Entity<UserModel>().HasComment("Tabla usuarios");
            modelBuilder.Entity<UserModel>().ToTable("Users", c => c.IsTemporal());

            modelBuilder.Entity<UserRolModel>().HasKey(e => new { e.UserId, e.RolId });
        }
    }
}
