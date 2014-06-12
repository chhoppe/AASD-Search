using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Filter
{
    public class CFilterPluginDummy : AASDSearch.Common.IFilterPlugin
    {
        public string Name
        {
            get { return "Filter Dummy";}
        }
        public string Desc
        {
            get { return "This Filter Pluigin does nothing, its just for testing porpuse "; }
        }
        public Version Version
        {
            get { return new Version(1,0,0,0); }
        }
        public void process (AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            // Dummy Filter does nothing
            
        }
    }
}
