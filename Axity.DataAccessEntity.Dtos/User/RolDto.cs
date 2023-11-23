using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Dtos.User
{
    public class RolDto
    {

        [Column("Pk_Rol")]
        public int Id { get; set; }

        [Column("Nombre")]
        public string Name { get; set; }
    }
}
