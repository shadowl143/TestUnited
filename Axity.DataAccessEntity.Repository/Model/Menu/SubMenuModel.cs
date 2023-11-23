using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Entities.Model.Menu
{
    public class SubMenuModel : MasterMenuModel
    {
        public int MenuId { get; set; }
        public MenuModel Menu { get; set; }
        public ICollection<PageModel> Pages { get; set; }
    }
}
