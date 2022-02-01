using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class HideIfExamples_Condition
    {
        public bool IsHidden;
        public bool IsHiddenProperty => IsHidden;

        [FoldoutGroup("Field Name Example")]
        [HideIf("IsHidden")]
        public string FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [HideIf("IsHiddenProperty")]
        public string PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [HideIf("@IsHidden")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [HideIf("GetHiddenState")]
        public string MethodNameExample;

        private bool GetHiddenState()
        {
            return IsHidden;
        }
    }
    // End
}