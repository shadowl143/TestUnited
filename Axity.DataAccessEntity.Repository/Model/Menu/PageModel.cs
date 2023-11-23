using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Entities.Model.Menu
{
    public class PageModel : MasterMenuModel
    {
        public int SubMenuId { get; set; }
        public SubMenuModel SubMenu { get; set; }
    }
}
