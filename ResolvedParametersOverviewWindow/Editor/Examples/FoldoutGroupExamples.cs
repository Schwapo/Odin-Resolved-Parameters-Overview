using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class FoldoutGroupExamples_GroupName
    {
        public bool UseAlternativeGroupName;
        public string GroupName = "Peace, Love & Ducks";
        public string AlternativeGroupName = "Peace, Love & Fenrir";
        public string GroupNameProperty => UseAlternativeGroupName ? AlternativeGroupName : GroupName;

        [FoldoutGroup("Field Name Example")]
        [FoldoutGroup("Field Name Example/Foldout", GroupName = "$GroupName")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [FoldoutGroup("Property Name Example/Foldout", GroupName = "$GroupNameProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [FoldoutGroup("Attribute Expression Example/Foldout", GroupName = "@UseAlternativeGroupName ? AlternativeGroupName : GroupName")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [FoldoutGroup("Method Name Example/Foldout", GroupName = "$GetGroupName")]
        public string MethodNameExample;

        private string GetGroupName()
        {
            return UseAlternativeGroupName ? AlternativeGroupName : GroupName;
        }
    }
    // End
}