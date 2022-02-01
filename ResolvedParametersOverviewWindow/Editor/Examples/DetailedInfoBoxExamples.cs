using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class DetailedInfoBoxExamples_VisibleIf
    {
        public bool IsVisible = true;
        public bool IsVisibleProperty => IsVisible;

        [FoldoutGroup("Field Name Example")]
        [DetailedInfoBox("Ducks are...", "Ducks are awesome", VisibleIf = "IsVisibles")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [DetailedInfoBox("Ducks are...", "Ducks are awesome", VisibleIf = "IsVisibleProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [DetailedInfoBox("Ducks are...", "Ducks are awesome", VisibleIf = "@IsVisible")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [DetailedInfoBox("Ducks are...", "Ducks are awesome", VisibleIf = "GetVisibility")]
        public string MethodNameExample;

        private bool GetVisibility()
        {
            return IsVisible;
        }
    }
    // End

    [ResolvedParameterExample]
    public class DetailedInfoBoxExamples_Message
    {
        public string Message = "Ducks are...";
        public string MessageProperty => Message;

        [FoldoutGroup("Field Name Example")]
        [DetailedInfoBox("$Message", "Ducks are awesome")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [DetailedInfoBox("$MessageProperty", "Ducks are awesome")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [DetailedInfoBox("@Message", "Ducks are awesome")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [DetailedInfoBox("$GetMessage", "Ducks are awesome")]
        public string MethodNameExample;

        private string GetMessage()
        {
            return Message;
        }
    }
    // End

    [ResolvedParameterExample]
    public class DetailedInfoBoxExamples_Details
    {
        public string Details = "Ducks are awesome";
        public string DetailsProperty => Details;

        [FoldoutGroup("Field Name Example")]
        [DetailedInfoBox("Ducks are...", "$Details")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [DetailedInfoBox("Ducks are...", "$DetailsProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [DetailedInfoBox("Ducks are...", "@Details")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [DetailedInfoBox("Ducks are...", "$GetDetails")]
        public string MethodNameExample;

        private string GetDetails()
        {
            return Details;
        }
    }
    // End
}