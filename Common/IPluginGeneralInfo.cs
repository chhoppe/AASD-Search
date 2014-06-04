using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    public interface IPluginGeneralInfo
    {
        string Name
        {
            get;
        }
        void processAsync (AASDSearch.Common.CSearchRequest pSearchrequest);
    }
}
