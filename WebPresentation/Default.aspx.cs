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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Common.CSearchRequest request = new Common.CSearchRequest();
            
            //var objBing = new Bing.BingSearchContainer(new Uri("https://api.datamarket.azure.com/Bing/Search"));
            var accountKey = "qsqVDvegggbvRRe72aAz85mCfXdlvMLf6B3yVMYauFk";
            //objBing.Credentials = new System.Net.NetworkCredential(accountKey, accountKey);
            //var webResult = objBing.Web(txtSearch.Text.ToString(), null, null, null, null, null, null, null);
            //GridViewSearchResult.DataSource = webResult;
            //GridViewSearchResult.DataBind();

        }
    }
}