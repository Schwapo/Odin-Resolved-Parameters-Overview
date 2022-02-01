using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class PropertyRangeExamples_MinGetter
    {
        public bool UseIncreasedMin;
        public float Min = 0f;
        public float IncreasedMin = 5f;
        public float MinProperty => UseIncreasedMin ? IncreasedMin : Min;

        [FoldoutGroup("Field Name Example")]
        [PropertyRange(minGetter: "Min", max: 10f)]
        public float FieldNameExample = 7.5f;
        
        [FoldoutGroup("Property Name Example")]
        [PropertyRange(minGetter: "MinProperty", max: 10f)]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [PropertyRange(minGetter: "@UseIncreasedMin ? IncreasedMin : Min", max: 10f)]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [PropertyRange(minGetter: "GetMin", max: 10f)]
        public float MethodNameExample = 7.5f;

        private float GetMin()
        {
            return UseIncreasedMin ? IncreasedMin : Min;
        }
    }
    // End

    [ResolvedParameterExample]
    public class PropertyRangeExamples_MaxGetter
    {
        public bool UseIncreasedMax;
        public float Max = 10f;
        public float IncreasedMax = 20f;
        public float MaxProperty => UseIncreasedMax ? IncreasedMax : Max;

        [FoldoutGroup("Field Name Example")]
        [PropertyRange(min: 0f, maxGetter: "Max")]
        public float FieldNameExample = 7.5f;
        
        [FoldoutGroup("Property Name Example")]
        [PropertyRange(min: 0f, maxGetter: "MaxProperty")]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [PropertyRange(min: 0f, maxGetter: "@UseIncreasedMax ? IncreasedMax : Max")]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [PropertyRange(min: 0f, maxGetter: "GetMax")]
        public float MethodNameExample = 7.5f;

        private float GetMax()
        {
            return UseIncreasedMax ? IncreasedMax : Max;
        }
    }
    // End
}