using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AASDSearch.Web
{
    public partial class _Default : Page
    {
        Common.CSearchRequest request = new Common.CSearchRequest();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSearch_Click (object sender, EventArgs e)
        {
            
            request.SearchString = TextBoxSearch.Text;

            Global.RefiningManager.process(request);
            Global.SearchManager.process(request);
            Global.FilterManager.process(request);
            
            GridViewSearchResult.DataSource = request.SearchResults;
            GridViewSearchResult.DataBind();              
        }
        protected void Button1_Click (object sender, EventArgs e)
        {
          
        }
    }
}