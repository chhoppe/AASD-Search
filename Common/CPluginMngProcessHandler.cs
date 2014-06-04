using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    class CPluginMngProcessHandler<T>
    {
        public CSearchRequest request;
        public List<T> plugins;
        public CPluginMngProcessHandler(CSearchRequest pSearchRequest)
        {
            request = pSearchRequest;
        }
    }
}
