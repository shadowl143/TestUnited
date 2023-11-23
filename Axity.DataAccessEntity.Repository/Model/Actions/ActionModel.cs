using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Actions
{
    [Table("Actions", Schema = "act")]
    public class ActionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
