using $rootnamespace$.Models.Blocks;
using EPiServer.Web;

namespace $rootnamespace$.Views.Blocks
{
    /// <summary>
    /// Base class for controls used to render blocks
    /// </summary>
    /// <typeparam name="T">Block type inheriting SiteBlockData</typeparam>
    public class SiteBlockControlBase<T> : BlockControlBase<T> where T : SiteBlockData
    {
        public SiteBlockControlBase()
        {
            EnableViewState = false;
        }
    }
}
