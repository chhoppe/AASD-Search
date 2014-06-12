using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Refining
{
    public class CRefiningPluginDummy : AASDSearch.Common.IRefiningPlugin
    {
        public string Name
        {
            get { return "Refining Dummy"; }
        }
        public string Desc
        {
            get { return "This Refining Pluigin does nothing, its just for testing porpuse "; }
        }
        public Version Version
        {
            get { return new Version(1, 0, 0, 0); }
        }
        public void process (AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            // Dummy Refining does nothing

        }
    }
}
