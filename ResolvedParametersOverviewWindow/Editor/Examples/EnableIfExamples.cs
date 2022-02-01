using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class EnableIfExamples_Condition
    {
        public bool IsEnabled;
        public bool IsEnabledProperty => IsEnabled;

        [FoldoutGroup("Field Name Example")]
        [EnableIf("IsEnabled")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [EnableIf("IsEnabledProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [EnableIf("@IsEnabled")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [EnableIf("GetEnabledState")]
        public string MethodNameExample;

        private bool GetEnabledState()
        {
            return IsEnabled;
        }
    }
    // End
}