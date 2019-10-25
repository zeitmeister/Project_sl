using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BaseService
    {

        protected bool IsObjectNotNull(params object[] list)
        {
            if (list.Any(item => item == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
