using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class HorizontalGroupExamples_Title
    {
        public bool UseAlternativeTitle;
        public string Title = "Peace, Love & Ducks";
        public string AlternativeTitle = "Peace, Love & Fenrir";
        public string TitleProperty => UseAlternativeTitle ? AlternativeTitle : Title;

        [FoldoutGroup("Field Name Example")]
        [HorizontalGroup("Field Name Example/Horizontal", Title = "$Title")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [HorizontalGroup("Property Name Example/Horizontal", Title = "$TitleProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [HorizontalGroup("Attribute Expression Example/Horizontal", Title = "@UseAlternativeTitle ? AlternativeTitle : Title")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [HorizontalGroup("Method Name Example/Horizontal", Title = "$GetTitle")]
        public string MethodNameExample;

        private string GetTitle()
        {
            return UseAlternativeTitle ? AlternativeTitle : Title;
        }
    }
    // End
}