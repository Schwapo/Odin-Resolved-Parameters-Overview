using System.Collections.Generic;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public class AttributeWithResolvedParameters
    {
        private const string UnformatedAttributeUrl = "https://odininspector.com/attributes/{0}";
        private const string UnformatedDocumentationUrl = "https://odininspector.com/documentation/sirenix.odininspector.{0}";

        public string Name;
        public string AttributeUrl;
        public string DocumentationUrl;
        public List<ResolvedParameter> ResolvedParameters;

        public AttributeWithResolvedParameters(string name, List<ResolvedParameter> resolvedParameters)
        {
            Name = name;
            ResolvedParameters = resolvedParameters;

            var attributeUrlName = $"{name.ToLower().Replace(' ', '-')}-attribute";
            var documentationUrlName = attributeUrlName.Replace("-", "");

            AttributeUrl = string.Format(UnformatedAttributeUrl, attributeUrlName);
            DocumentationUrl = string.Format(UnformatedDocumentationUrl, documentationUrlName);
        }
    }
}
