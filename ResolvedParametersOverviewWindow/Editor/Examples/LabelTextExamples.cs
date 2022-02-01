using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class LabelTextExamples_Text
    {
        public string Label = "Peace, Love & Ducks";
        public string LabelProperty => Label;

        [FoldoutGroup("Field Name Example")]
        [LabelText("$Label")]
        public string FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [LabelText("$LabelProperty")]
        public string PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [LabelText("@Label")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [LabelText("$GetLabel")]
        public string MethodNameExample;

        private string GetLabel()
        {
            return Label;
        }
    }
    // End
}