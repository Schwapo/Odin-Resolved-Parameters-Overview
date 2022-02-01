using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class HideIfGroupExamples_Condition
    {
        public bool HideGroup;
        public bool HideGroupProperty => HideGroup;

        [HideIfGroup("Hidden", Condition = "HideGroup")]
        [FoldoutGroup("Hidden/Field Name Example")]
        public string FieldNameExample;
        
        [HideIfGroup("Hidden", Condition = "HideGroupProperty")]
        [FoldoutGroup("Hidden/Property Name Example")]
        public string PropertyNameExample;
        
        [HideIfGroup("Hidden", Condition = "@HideGroup")]
        [FoldoutGroup("Hidden/Attribute Expression Example")]
        public string AttributeExpressionExample;
        
        [HideIfGroup("Hidden", Condition = "GetHiddenState")]
        [FoldoutGroup("Hidden/Method Name Example")]
        public string MethodNameExample;

        private bool GetHiddenState()
        {
            return HideGroup;
        }
    }
    // End
}