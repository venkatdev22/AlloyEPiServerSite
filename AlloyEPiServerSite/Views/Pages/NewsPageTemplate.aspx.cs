using System;
using EPiServer.Core;
using AlloyEPiServerSite.Models.Pages;

namespace AlloyEPiServerSite.Views.Pages
{
    public partial class NewsPageTemplate : SiteTemplatePage<NewsPage>
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NoListRootMessage.DataBind();
        }
    }
}
