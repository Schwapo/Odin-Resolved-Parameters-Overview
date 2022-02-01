using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class DisableIfExamples_Condition
    {
        public bool IsDisabled;
        public bool IsDisabledProperty => IsDisabled;

        [FoldoutGroup("Field Name Example")]
        [DisableIf("IsDisabled")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [DisableIf("IsDisabledProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [DisableIf("@IsDisabled")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [DisableIf("GetDisabledState")]
        public string MethodNameExample;

        private bool GetDisabledState()
        {
            return IsDisabled;
        }
    }
    // End
}