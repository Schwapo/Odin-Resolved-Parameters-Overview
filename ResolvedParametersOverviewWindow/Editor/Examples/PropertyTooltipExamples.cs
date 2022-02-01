using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class PropertyTooltipExamples_Tooltip
    {
        public bool UseAlternativeTooltip;
        public string Tooltip = "Peace, Love & Ducks";
        public string AlternativeTooltip = "Peace, Love & Fenrir";
        public string TooltipProperty => UseAlternativeTooltip ? AlternativeTooltip : Tooltip;

        [FoldoutGroup("Field Name Example")]
        [InfoBox("Hover over the field label")]
        [PropertyTooltip("$Tooltip")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [InfoBox("Hover over the field label")]
        [PropertyTooltip("$TooltipProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Hover over the field label")]
        [PropertyTooltip("@UseAlternativeTooltip ? AlternativeTooltip : Tooltip")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [InfoBox("Hover over the field label")]
        [PropertyTooltip("$GetTooltip")]
        public string MethodNameExample;

        private string GetTooltip()
        {
            return UseAlternativeTooltip ? AlternativeTooltip : Tooltip;
        }
    }
    // End
}