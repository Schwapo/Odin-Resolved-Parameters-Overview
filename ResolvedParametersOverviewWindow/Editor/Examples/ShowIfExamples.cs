using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ShowIfExamples_Condition
    {
        public bool Show = true;
        public bool ShowProperty => Show;

        [FoldoutGroup("Field Name Example")]
        [ShowIf("Show")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [ShowIf("ShowProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [ShowIf("@Show")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [ShowIf("GetShowState")]
        public string MethodNameExample;

        private bool GetShowState()
        {
            return Show;
        }
    }
    // End
}