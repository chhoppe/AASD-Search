using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AASDSearch.Search
{
    public class CSearchPluginBing : ISearchPlugin
    {
        private const string AccountKey = "CHgarYrK/CZEsK2nS35YHXg1WnkJ9B2b7nqCNYRUmP8";
        public string Name
        {
            get
            {
                return "Bing Search Engine";
            }
        }
        public void process(AASDSearch.Common.CSearchRequest pSearchrequest)
        {
            try
            {
                string query = pSearchrequest.SearchString;

                // Create a Bing container.
                string rootUrl = "https://api.datamarket.azure.com/Bing/Search";
                var bingContainer = new Bing.BingSearchContainer(new Uri(rootUrl));

                // The market to use.
                string market = pSearchrequest.Language;

                // Configure bingContainer to use your credentials.
                bingContainer.Credentials = new NetworkCredential(AccountKey, AccountKey);

                // Build the query, limiting to 10 results.
                var webQuery =
                    bingContainer.Web(query, null, null, market, null, null, null, null);
                webQuery = webQuery.AddQueryOption("$top", 10);

                // Run the query and display the results.
                var webResults = webQuery.Execute();

                foreach (var result in webResults)
                {
                    AASDSearch.Common.CSearchResult searchresult = new AASDSearch.Common.CSearchResult();
                    searchresult.Title = result.Title;
                    searchresult.Type = Common.SearchResulttype.Web;
                    searchresult.Description = result.Description;
                    searchresult.ID = result.ID;
                    searchresult.Url = result.Url;
                    searchresult.DisplayUrl = result.DisplayUrl;
                    pSearchrequest.SearchResults.Add(searchresult);
                }
            }
            catch (Exception ex)
            {
                string innerMessage =
                    (ex.InnerException != null) ?
                    ex.InnerException.Message : String.Empty;
                pSearchrequest.ErrorMsg = string.Format("{0}\n{1}", ex.Message, innerMessage);
            }
        }
    }      
}
