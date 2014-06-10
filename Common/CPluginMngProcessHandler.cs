using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    /// <summary>
    ///  help structure for plugin manager processing a searchrequest
    /// </summary>
    /// <typeparam name="T">specific plugin type</typeparam>
    class CPluginMngProcessHandler<T>
    {
        public CSearchRequest request;
        public List<T> plugins;
        public CPluginMngProcessHandler(CSearchRequest pSearchRequest)
        {
            request = pSearchRequest;
            plugins = new List<T>();
        }
    }
}
