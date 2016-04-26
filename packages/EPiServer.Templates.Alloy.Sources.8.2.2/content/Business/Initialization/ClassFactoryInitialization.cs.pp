using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.SpecializedProperties;
using $rootnamespace$.Business.WebControls;
using EPiServer.Framework.Initialization;

namespace $rootnamespace$.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class ClassFactoryInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                // Use our own control to render content areas
                PropertyControlClassFactory.Instance.RegisterClass(
                    typeof(PropertyContentArea), // We want to use our own control whenever a PropertyContentArea property is rendered
                    typeof(SitePropertyContentAreaControl)); // Use our own control derived from PropertyContentAreaControl, customized for the Bootstrap HTML framework
            }
        }

        public void Preload(string[] parameters) { }

        public void Uninitialize(InitializationEngine context) { }
    }
}
