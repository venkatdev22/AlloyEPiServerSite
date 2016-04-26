using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;

namespace AlloyEPiServerSite.Business.EditorDescriptors
{
    /// <summary>
    /// Register an editor for StringList properties
    /// </summary>
    [EditorDescriptorRegistration(TargetType = typeof(String[]), UIHint = Global.SiteUIHints.Strings)]
    public class StringList : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "alloy/editors/StringList";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}
