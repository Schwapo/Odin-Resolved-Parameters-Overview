using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class MaxValueExamples_Expression
    {
        public float MaxValue = 10f;
        public float MaxValueProperty => MaxValue;

        [FoldoutGroup("Field Name Example")]
        [MaxValue("MaxValue")]
        public float FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [MaxValue("MaxValueProperty")]
        public float PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [MaxValue("@MaxValue")]
        public float AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [MaxValue("GetMaxValue")]
        public float MethodNameExample;

        private float GetMaxValue()
        {
            return MaxValue;
        }
    }
    // End
}