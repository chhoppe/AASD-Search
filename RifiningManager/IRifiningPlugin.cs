using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Rifining
{
    public interface IRifiningPlugin : AASDSearch.Common.IPluginGeneralInfo
    {
        public string Name
        {
            get
            {
                return "Filter Dummy";
            }
        }
        public bool processAsync (AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            // Dummy Filter does nothing
            return true;
        }

    }
}
