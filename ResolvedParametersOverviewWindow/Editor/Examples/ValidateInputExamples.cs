using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ValidateInputExamples_DefaultMessage
    {
        public bool UseAlternativeMessage = true;
        public string Message = "Peace, Love & Ducks";
        public string AlternativeMessage = "Peace, Love & Fenrir";
        public string MessageProperty => UseAlternativeMessage ? AlternativeMessage : Message;

        [FoldoutGroup("Field Name Example")]
        [ValidateInput("@false", defaultMessage: "$Message", ContinuousValidationCheck = true)]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [ValidateInput("@false", defaultMessage: "$AlternativeMessage", ContinuousValidationCheck = true)]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [ValidateInput("@false",
            defaultMessage: "@UseAlternativeMessage ? AlternativeMessage : Message",
            ContinuousValidationCheck = true)]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [ValidateInput("@false", defaultMessage: "$GetMessage", ContinuousValidationCheck = true)]
        public string MethodNameExample;

        private string GetMessage()
        {
            return UseAlternativeMessage ? AlternativeMessage : Message;
        }
    }
    // End

    [ResolvedParameterExample]
    public class ValidateInputExamples_Condition
    {
        [FoldoutGroup("Attribute Expression Example")]
        [ValidateInput(condition: "@!string.IsNullOrWhiteSpace($value)", "Field can't be empty")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [ValidateInput("IsValid")]
        public string MethodNameExample;

        private bool IsValid(string value, ref string message, ref InfoMessageType messageType)
        {
            message = "Field can't be empty";
            messageType = InfoMessageType.Error;

            return !string.IsNullOrWhiteSpace(value);
        }
    }
    // End
}