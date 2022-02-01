using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class InfoBoxExamples_VisibleIf
    {
        public bool IsVisible = true;
        public bool IsVisibleProperty => IsVisible;

        [FoldoutGroup("Field Name Example")]
        [InfoBox("Ducks are awesome", VisibleIf = "IsVisible")]
        public string FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [InfoBox("Ducks are awesome", VisibleIf = "IsVisibleProperty")]
        public string PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Ducks are awesome", VisibleIf = "@IsVisible")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [InfoBox("Ducks are awesome", VisibleIf = "GetVisibility")]
        public string MethodNameExample;

        private bool GetVisibility()
        {
            return IsVisible;
        }
    }
    // End

    [ResolvedParameterExample]
    public class InfoBoxExamples_Message
    {
        public string Message = "Ducks are awesome";
        public string MessageProperty => Message;

        [FoldoutGroup("Field Name Example")]
        [InfoBox("$Message")]
        public string FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [InfoBox("$MessageProperty")]
        public string PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("@Message")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [InfoBox("$GetMessage")]
        public string MethodNameExample;

        private string GetMessage()
        {
            return Message;
        }
    }
    // End
}