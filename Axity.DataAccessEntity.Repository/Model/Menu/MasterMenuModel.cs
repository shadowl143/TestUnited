using System.ComponentModel.DataAnnotations;

namespace Axity.DataAccessEntity.Entities.Model.Menu
{
    public class MasterMenuModel
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }

        public string Icon { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
