using Sirenix.OdinInspector;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class MinMaxSliderExamples_MinMaxValueGetter
    {
        public bool ExpandRange;
        public Vector2 MinMaxValues = new Vector2(0f, 10f);
        public Vector2 MinMaxValuesExpanded = new Vector2(0f, 20f);
        public Vector2 MinMaxValuesProperty => ExpandRange ? MinMaxValuesExpanded : MinMaxValues;

        [FoldoutGroup("Field Name Example")]
        [MinMaxSlider(minMaxValueGetter: "MinMaxValues")]
        public Vector2 FieldNameExample = new Vector2(0f, 10f);

        [FoldoutGroup("Property Name Example")]
        [MinMaxSlider(minMaxValueGetter: "MinMaxValuesProperty")]
        public Vector2 PropertyNameExample = new Vector2(0f, 10f);
        
        [FoldoutGroup("Attribute Expression Example")]
        [MinMaxSlider(minMaxValueGetter: "@ExpandRange ? MinMaxValuesExpanded : MinMaxValues")]
        public Vector2 AttributeExpressionExample = new Vector2(0f, 10f);
        
        [FoldoutGroup("Method Name Example")]
        [MinMaxSlider(minMaxValueGetter: "GetMinMaxValues")]
        public Vector2 MethodNameExample = new Vector2(0f, 10f);

        private Vector2 GetMinMaxValues()
        {
            return ExpandRange ? MinMaxValuesExpanded : MinMaxValues;
        }
    }
    // End

    [ResolvedParameterExample]
    public class MinMaxSliderExamples_MinValueGetter
    {
        public bool UseIncreasedMinValue;
        public float MinValue = 0f;
        public float IncreasedMinValue = 5f;
        public float MinValueProperty => UseIncreasedMinValue ? IncreasedMinValue : MinValue;

        [FoldoutGroup("Field Name Example")]
        [MinMaxSlider(minValueGetter: "MinValue", maxValue: 10f)]
        public Vector2 FieldNameExample = new Vector2(7.5f, 10f);

        [FoldoutGroup("Property Name Example")]
        [MinMaxSlider(minValueGetter: "MinValueProperty", maxValue: 10f)]
        public Vector2 PropertyNameExample = new Vector2(7.5f, 10f);
        
        [FoldoutGroup("Attribute Expression Example")]
        [MinMaxSlider(minValueGetter: "@UseIncreasedMinValue ? IncreasedMinValue : MinValue", maxValue: 10f)]
        public Vector2 AttributeExpressionExample = new Vector2(7.5f, 10f);
        
        [FoldoutGroup("Method Name Example")]
        [MinMaxSlider(minValueGetter: "GetMinValue", maxValue: 10f)]
        public Vector2 MethodNameExample = new Vector2(7.5f, 10f);

        private float GetMinValue()
        {
            return UseIncreasedMinValue ? IncreasedMinValue : MinValue;
        }
    }
    // End

    [ResolvedParameterExample]
    public class MinMaxSliderExamples_MaxValueGetter
    {
        public bool UseIncreasedMaxValue;
        public float MaxValue = 10f;
        public float IncreasedMaxValue = 20f;
        public float MaxValueProperty => UseIncreasedMaxValue ? IncreasedMaxValue : MaxValue;

        [FoldoutGroup("Field Name Example")]
        [MinMaxSlider(minValue: 0f, maxValueGetter: "MaxValue")]
        public Vector2 FieldNameExample = new Vector2(0f, 10f);

        [FoldoutGroup("Property Name Example")]
        [MinMaxSlider(minValue: 0f, maxValueGetter: "MaxValueProperty")]
        public Vector2 PropertyNameExample = new Vector2(0f, 10f);
        
        [FoldoutGroup("Attribute Expression Example")]
        [MinMaxSlider(minValue: 0f, maxValueGetter: "@UseIncreasedMaxValue ? IncreasedMaxValue : MaxValue")]
        public Vector2 AttributeExpressionExample = new Vector2(0f, 10f);
        
        [FoldoutGroup("Method Name Example")]
        [MinMaxSlider(minValue: 0f, maxValueGetter: "GetMaxValue")]
        public Vector2 MethodNameExample = new Vector2(0f, 10f);

        private float GetMaxValue()
        {
            return UseIncreasedMaxValue ? IncreasedMaxValue : MaxValue;
        }
    }
    // End
}