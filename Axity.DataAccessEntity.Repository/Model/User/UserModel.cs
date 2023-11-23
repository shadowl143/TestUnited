
namespace Axity.DataAccessEntity.Entities.Model.User
{
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Index(nameof(UserName), IsUnique = true)]

    public class UserModel
    {
        public int Id { get; set; }
        [StringLength(120)]
        [Required]
        public string UserName { get; set; }
        [StringLength(200)]
        [Required]
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
        public bool Status { get; set; }

        [NotMapped]
        public string Estado { get; set; }
        public DateTime RegisterDate { get; set; }

        public ICollection<UserRolModel> UserRol { get; set; }
    }
}
