using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class TitleGroupExamples_GroupName
    {
        public bool UseAlternativeTitle;
        public string Title = "Peace, Love & Ducks";
        public string AlternativeTitle = "Peace, Love & Fenrir";
        public string TitleProperty => UseAlternativeTitle ? AlternativeTitle : Title;

        [FoldoutGroup("Field Name Example")]
        [TitleGroup("Field Name Example/Title", GroupName = "$Title")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [TitleGroup("Property Name Example/Title", GroupName = "$TitleProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [TitleGroup("Attribute Expression Example/Title", GroupName = "@UseAlternativeTitle ? AlternativeTitle : Title")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [TitleGroup("Method Name Example/Title", GroupName = "$GetTitle")]
        public string MethodNameExample;

        private string GetTitle()
        {
            return UseAlternativeTitle ? AlternativeTitle : Title;
        }
    }
    // End

    [ResolvedParameterExample]
    public class TitleGroupExamples_Subtitle
    {
        public bool UseAlternativeSubtitle;
        public string Subtitle = "Peace, Love & Ducks";
        public string AlternativeSubtitle = "Peace, Love & Fenrir";
        public string SubtitleProperty => UseAlternativeSubtitle ? AlternativeSubtitle : Subtitle;

        [FoldoutGroup("Field Name Example")]
        [TitleGroup("Field Name Example/Title", Subtitle = "$Subtitle")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [TitleGroup("Property Name Example/Title", Subtitle = "$SubtitleProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [TitleGroup("Attribute Expression Example/Title", Subtitle = "@UseAlternativeSubtitle ? AlternativeSubtitle : Subtitle")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [TitleGroup("Method Name Example/Title", Subtitle = "$GetSubtitle")]
        public string MethodNameExample;

        private string GetSubtitle()
        {
            return UseAlternativeSubtitle ? AlternativeSubtitle : Subtitle;
        }
    }
    // End
}