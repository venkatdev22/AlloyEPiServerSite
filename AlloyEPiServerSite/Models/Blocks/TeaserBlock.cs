using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyEPiServerSite.Models.Blocks
{
    /// <summary>
    /// Used to provide a stylized entry point to a page on the site
    /// </summary>
    [SiteContentType(GUID = "EB67A99A-E239-41B8-9C59-20EAA5936047")] // BEST PRACTICE TIP: Always assign a GUID explicitly when creating a new block type
    [SiteImageUrl] // Use site's default thumbnail
    public class TeaserBlock : SiteBlockData
    {
        // BEST PRACTICE TIP: To easily allow for page type-specific localizations, append property names with the name of the block type

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }
        
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.LongString)]
        public virtual string Text { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual PageReference Link { get; set; }
    }
}
