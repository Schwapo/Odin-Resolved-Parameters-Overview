using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class TitleExamples_Title
    {
        public bool UseAlternativeTitle;
        public string Title = "Peace, Love & Ducks";
        public string AlternativeTitle = "Peace, Love & Fenrir";
        public string TitleProperty => UseAlternativeTitle ? AlternativeTitle : Title;

        [FoldoutGroup("Field Name Example")]
        [Title("$Title")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [Title("$TitleProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [Title("@UseAlternativeTitle ? AlternativeTitle : Title")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [Title("$GetTitle")]
        public string MethodNameExample;

        private string GetTitle()
        {
            return UseAlternativeTitle ? AlternativeTitle : Title;
        }
    }
    // End

    [ResolvedParameterExample]
    public class TitleExamples_Subtitle
    {
        public bool UseAlternativeSubtitle;
        public string Subtitle = "Peace, Love & Ducks";
        public string AlternativeSubtitle = "Peace, Love & Fenrir";
        public string SubtitleProperty => UseAlternativeSubtitle ? AlternativeSubtitle : Subtitle;

        [FoldoutGroup("Field Name Example")]
        [Title("Title", "$Subtitle")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [Title("Title", "$SubtitleProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [Title("Title", "@UseAlternativeSubtitle ? AlternativeSubtitle : Subtitle")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [Title("Title", "$GetSubtitle")]
        public string MethodNameExample;

        private string GetSubtitle()
        {
            return UseAlternativeSubtitle ? AlternativeSubtitle : Subtitle;
        }
    }
    // End
}