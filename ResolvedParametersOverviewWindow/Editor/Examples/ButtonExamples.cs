using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ButtonExamples_Name
    {
        public bool UseAwesomeName;
        public string AwesomeName = "Peace, Love & Ducks";
        public string BoringName = "Button";
        public string AwesomeNameProperty => UseAwesomeName ? AwesomeName : BoringName;

        [FoldoutGroup("Field Name Example")]
        [Button(Name = "$AwesomeName")]
        public void FieldNameExample() { }

        [FoldoutGroup("Property Name Example")]
        [Button(Name = "$AwesomeNameProperty")]
        public void PropertyNameExample() { }

        [FoldoutGroup("Attribute Expression Example")]
        [Button(Name = "@UseAwesomeName ? AwesomeName : BoringName")]
        public void AttributeExpressionExample() { }

        [FoldoutGroup("Method Name Example")]
        [Button(Name = "$GetButtonName")]
        public void MethodNameExample() { }

        private string GetButtonName()
        {
            return UseAwesomeName ? AwesomeName : BoringName;
        }
    }
    // End
}