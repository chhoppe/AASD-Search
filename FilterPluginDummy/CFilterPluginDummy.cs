using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Filter
{
    public class CFilterPluginDummy : IFilterPlugin
    {
        public string Name
        {
            get { return "Filter Dummy";}
        }
        public void process (AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            // Dummy Filter does nothing
            
        }

    }
}
