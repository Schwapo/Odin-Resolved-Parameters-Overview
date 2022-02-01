using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class SuffixLabelExamples_Label
    {
        public bool UseAlternativeLabel;
        public string Label = "Peace, Love & Ducks";
        public string AlternativeLabel = "Peace, Love & Fenrir";
        public string LabelProperty => UseAlternativeLabel ? AlternativeLabel : Label;

        [FoldoutGroup("Field Name Example")]
        [SuffixLabel("$Label")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [SuffixLabel("$LabelProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [SuffixLabel("@UseAlternativeLabel ? AlternativeLabel : Label")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [SuffixLabel("$GetLabel")]
        public string MethodNameExample;

        private string GetLabel()
        {
            return UseAlternativeLabel ? AlternativeLabel : Label;
        }
    }
    // End
}