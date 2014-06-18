using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Filter
{
    public class CFilterPluginFreeBase : AASDSearch.Common.IFilterPlugin
    {
        public string Name
        {
            get { return "Filter using FreeBase"; }
        }
        public string Desc
        {
            get { return "This Filter Pluigin uses FreeBase to filter the search results."; }
        }
        public Version Version
        {
            get { return new Version(1, 0, 0, 0); }
        }
        public void process(AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            //  Filter functionallity does nothing

        }
    }
}

