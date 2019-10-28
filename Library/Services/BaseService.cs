using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// A Baseservice class that implements a null check
    /// </summary>
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
