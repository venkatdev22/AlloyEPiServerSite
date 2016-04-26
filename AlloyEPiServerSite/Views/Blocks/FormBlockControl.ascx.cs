using AlloyEPiServerSite.Models.Blocks;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;

namespace AlloyEPiServerSite.Views.Blocks
{
    [TemplateDescriptor(Inherited = true, TemplateTypeCategory = TemplateTypeCategories.UserControl)]
    public partial class FormBlockControl : SiteBlockControlBase<FormBlock> { }
}
