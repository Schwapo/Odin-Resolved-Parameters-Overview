using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ShowIfGroupExamples_Condition
    {
        public bool ShowGroup = true;
        public bool ShowGroupProperty => ShowGroup;

        [ShowIfGroup("Show", Condition = "ShowGroup")]
        [FoldoutGroup("Show/Field Name Example")]
        public string FieldNameExample;
        
        [ShowIfGroup("Show", Condition = "ShowGroupProperty")]
        [FoldoutGroup("Show/Property Name Example")]
        public string PropertyNameExample;
        
        [ShowIfGroup("Show", Condition = "@ShowGroup")]
        [FoldoutGroup("Show/Attribute Expression Example")]
        public string AttributeExpressionExample;
        
        [ShowIfGroup("Show", Condition = "GetShowState")]
        [FoldoutGroup("Show/Method Name Example")]
        public string MethodNameExample;

        private bool GetShowState()
        {
            return ShowGroup;
        }
    }
    // End
}