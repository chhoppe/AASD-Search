using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Refining
{
    public class CRefiningPluginDummy : AASDSearch.Refining.IRefiningPlugin
    {
        public string Name
        {
            get
            {
                return "Refining Dummy";
            }
        }
        async public void processAsync (AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            // Dummy Filter does nothing
            await Task.Run(( ) =>
            {
                
            });
        }
    }
}
