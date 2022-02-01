using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class RequiredExamples_ErrorMessage
    {
        public bool UseAlternativeMessage;
        public string Message = "Peace, Love & Ducks";
        public string AlternativeMessage = "Peace, Love & Fenrir";
        public string MessageProperty => UseAlternativeMessage ? AlternativeMessage : Message;

        [FoldoutGroup("Field Name Example")]
        [Required(ErrorMessage = "$Message")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [Required(ErrorMessage = "$MessageProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [Required(ErrorMessage = "@UseAlternativeMessage ? AlternativeMessage : Message")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [Required(ErrorMessage = "$GetMessage")]
        public string MethodNameExample;

        private string GetMessage()
        {
            return UseAlternativeMessage ? AlternativeMessage : Message;
        }
    }
    // End
}