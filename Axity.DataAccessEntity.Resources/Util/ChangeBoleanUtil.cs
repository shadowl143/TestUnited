using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Resources.Util
{
    public static class ChangeBoleanUtil
    {
        public static string ChangeStatus(this bool status)
        {
            if (status)
            {
                return "Activo";
            }
            return "InActivo";
        }
    }
}
