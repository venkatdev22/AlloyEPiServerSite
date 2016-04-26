using System;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using AlloyEPiServerSite.Business.Channels;
using AlloyEPiServerSite.Models.Blocks;

namespace AlloyEPiServerSite.Views.Blocks
{
    [TemplateDescriptor(
        Default = true, 
        Inherited = true, 
        TemplateTypeCategory = TemplateTypeCategories.UserControl,
        Tags = new[] { MobileChannel.Tag, Global.ContentAreaTags.OneThirdWidth },
        AvailableWithoutTag = true)]
    public partial class TeaserBlockControl : SiteBlockControlBase<TeaserBlock>
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DataBind(); // Since we use data binding expressions for the Property controls' Visible property
        }
    }
}
