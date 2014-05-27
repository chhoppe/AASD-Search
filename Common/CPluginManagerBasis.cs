using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    public class CPluginManagerBasis
    {
        private List<Type> pluginList;

        public CPluginManagerBasis ( )
        {
            pluginList = new List<Type>();
            
        }

        private void registerPlugin(Type PluginType)
        {
            if (! pluginList.Exists( x => x == PluginType) )
                pluginList.Add(PluginType);
        }
    }
}
