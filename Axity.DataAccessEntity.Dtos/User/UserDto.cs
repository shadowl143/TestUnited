using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Axity.DataAccessEntity.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [StringLength(200, ErrorMessage = "No cumplle con caracter maximos")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Password { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }
        [StringLength(50)]
        public string SecondLastName { get; set; }
        [StringLength(120)]
        [Required]
        public string Mail { get; set; }
        [StringLength(120)]
        [Required]
        public string Phone { get; set; }
        public string Status { get; set; }
        public DateTime RegisterDate { get; set; }

        public ICollection<RolDto> Rols { get; set; }
    }
}
