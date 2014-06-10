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
        public static AASDSearch.Rifining.CRifiningManager RifiningManager;
        public static AASDSearch.Search.CSearchManager SearchManager;
        public static AASDSearch.Filter.CFilterManager FilterManager;


        void Application_Start(object sender, EventArgs e)
        {
            // Code, der beim Anwendungsstart ausgeführt wird
            RifiningManager = new Rifining.CRifiningManager();
            RifiningManager.registerPlugin(typeof(AASDSearch.Rifining.CRifiningPluginDummy));
            RifiningManager.Lock();

            SearchManager = new Search.CSearchManager();
            SearchManager.registerPlugin(typeof(AASDSearch.Search.CSearchPluginBing));
            SearchManager.Lock();

            FilterManager = new Filter.CFilterManager();
            FilterManager.registerPlugin(typeof(AASDSearch.Filter.CFilterPluginDummy));
            FilterManager.Lock();


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
