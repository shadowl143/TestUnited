using Axity.DataAccessEntity.Entities.Model.Rols;

namespace Axity.DataAccessEntity.Entities.Model.User
{
    public class UserRolModel
    {
        public int UserId { get; set; }
        public int RolId { get; set; }

        public UserModel User { get; set; }
        public RolModel Rol{ get; set; }
    }
}
