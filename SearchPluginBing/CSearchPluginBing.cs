using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Search
{
    public class CSearchPluginBing : ISearchPlugin
    {
        public string Name
        {
            get
            {
                return "Bing Search Engine";
            }
        }
        async public void processAsync (AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            await Task.Run(( ) =>
            {

            });
        }
    }
}
