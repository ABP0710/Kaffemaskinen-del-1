using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen_del_1.Classes
{
    public class FilterHolder
    {
        public Filter filter { get; set; }

        public string InsertFilter(Filter filt)
        {
            if (filter != null)
            {
                return "the holder needs to be emptied";
            }
            else
            {
                filter = filt;
                return "Filter added";
            }
        }

        public string emptyHolder()
        {
            filter = null;
            return "emptying holder";
        }
    }
}
