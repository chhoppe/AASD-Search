using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Rifining
{
    public class CRifiningPluginDummy : AASDSearch.Rifining.IRifiningPlugin
    {
        public string Name
        {
            get
            {
                return "Rifining Dummy";
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
