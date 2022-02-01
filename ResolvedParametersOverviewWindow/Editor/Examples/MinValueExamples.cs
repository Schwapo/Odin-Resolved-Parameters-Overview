using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class MinValueExamples_Expression
    {
        public float MinValue = 10f;
        public float MinValueProperty => MinValue;

        [FoldoutGroup("Field Name Example")]
        [MinValue("MinValue")]
        public float FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [MinValue("MinValueProperty")]
        public float PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [MinValue("@MinValue")]
        public float AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [MinValue("GetMinValue")]
        public float MethodNameExample;

        private float GetMinValue()
        {
            return MinValue;
        }
    }
    // End

}