using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper.GuidTool
{
    public class GuidHelper
    {
        public static string GetUniqName()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
