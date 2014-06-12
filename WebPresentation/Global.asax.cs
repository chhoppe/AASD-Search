using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebPresentation;

namespace AASDSearch.Web
{
    public class Global : HttpApplication
    {
        public static AASDSearch.Refining.CRefiningManager RefiningManager =  new AASDSearch.Refining.CRefiningManager();
        public static AASDSearch.Search.CSearchManager SearchManager = new AASDSearch.Search.CSearchManager();
        public static AASDSearch.Filter.CFilterManager FilterManager = new AASDSearch.Filter.CFilterManager();


        void Application_Start(object sender, EventArgs e)
        {
            // Code, der beim Anwendungsstart ausgeführt wird

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code, der beim Herunterfahren der Anwendung ausgeführt wird

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code, der ausgeführt wird, wenn ein nicht behandelter Fehler auftritt

        }
    }
}
