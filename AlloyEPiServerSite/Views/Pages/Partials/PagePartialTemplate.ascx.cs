using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using AlloyEPiServerSite.Models.Pages;
using EPiServer.Web;

namespace AlloyEPiServerSite.Views.Pages.Partials
{
    /// <summary>
    /// Renders a product page teaser when a product page is dropped in a content area
    /// </summary>
    [TemplateDescriptor(Default = true, Inherited = true, TemplateTypeCategory = TemplateTypeCategories.UserControl)]
    public partial class PagePartialTemplate : PartialPageTemplate<SitePageData>
    {
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            DataBind();
        }
    }
}
