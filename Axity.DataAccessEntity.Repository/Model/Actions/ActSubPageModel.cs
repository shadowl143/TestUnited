using Axity.DataAccessEntity.Entities.Model.Menu;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Actions
{
    [Table("ActSubPages", Schema = "act")]
    public class ActSubPageModel
    {
        public int Id { get; set; }

        [Required]
        public int ActionId { get; set; }
        public int? FkPage { get; set; }
        public int? SubMenuId { get; set; }

        [ForeignKey("FkPage")]
        public PageModel Page { get; set; }
        public ActionModel Action { get; set; }
        public SubMenuModel SubMenu { get; set; }
    }
}
