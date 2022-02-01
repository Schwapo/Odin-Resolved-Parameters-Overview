using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class BoxGroupExamples_LabelText
    {
        public bool UseAlternativeLabel;
        public string Label = "Peace, Love & Ducks";
        public string AlternativeLabel = "Peace, Love & Fenrir";
        public string LabelProperty => UseAlternativeLabel ? AlternativeLabel : Label;

        [FoldoutGroup("Field Name Example")]
        [BoxGroup("Field Name Example/Box", LabelText = "$Label")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [BoxGroup("Property Name Example/Box", LabelText = "$LabelProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [BoxGroup("Attribute Expression Example/Box", LabelText = "@UseAlternativeLabel ? AlternativeLabel : Label")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [BoxGroup("Method Name Example/Box", LabelText = "$GetLabelText")]
        public string MethodNameExample;

        private string GetLabelText()
        {
            return UseAlternativeLabel ? AlternativeLabel : Label;
        }
    }
    // End
}