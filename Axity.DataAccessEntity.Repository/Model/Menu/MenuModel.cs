using System.Collections.Generic;

namespace Axity.DataAccessEntity.Entities.Model.Menu
{
    public class MenuModel : MasterMenuModel
    {
        public ICollection<SubMenuModel> SubMenu { get; set; }
    }
}
