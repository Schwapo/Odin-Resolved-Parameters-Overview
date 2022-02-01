using Sirenix.OdinInspector;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ProgressBarExamples_MinGetter
    {
        public bool UseIncreasedMin;
        public float Min = 0f;
        public float IncreasedMin = 5f;
        public float MinProperty => UseIncreasedMin ? IncreasedMin : Min;

        [FoldoutGroup("Field Name Example")]
        [ProgressBar(minGetter: "Min", max: 10f)]
        public float FieldNameExample = 7.5f;

        [FoldoutGroup("Property Name Example")]
        [ProgressBar(minGetter: "MinProperty", max: 10f)]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [ProgressBar(minGetter: "@UseIncreasedMin ? IncreasedMin : Min", max: 10f)]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [ProgressBar(minGetter: "GetMin", max: 10f)]
        public float MethodNameExample = 7.5f;

        private float GetMin()
        {
            return UseIncreasedMin ? IncreasedMin : Min;
        }
    }
    // End

    [ResolvedParameterExample]
    public class ProgressBarExamples_MaxGetter
    {
        public bool UseIncreasedMax;
        public float Max = 10f;
        public float IncreasedMax = 20f;
        public float MaxProperty => UseIncreasedMax ? IncreasedMax : Max;

        [FoldoutGroup("Field Name Example")]
        [ProgressBar(min: 0f, maxGetter: "Max")]
        public float FieldNameExample = 7.5f;

        [FoldoutGroup("Property Name Example")]
        [ProgressBar(min: 0f, maxGetter: "MaxProperty")]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [ProgressBar(min: 0f, maxGetter: "@UseIncreasedMax ? IncreasedMax : Max")]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [ProgressBar(min: 0f, maxGetter: "GetMax")]
        public float MethodNameExample = 7.5f;

        private float GetMax()
        {
            return UseIncreasedMax ? IncreasedMax : Max;
        }
    }
    // End

    [ResolvedParameterExample]
    public class ProgressBarExamples_ColorGetter
    {
        public bool UseAlternativeColor;
        public Color Color = new Color(0.11f, 0.77f, 0.5f, 1f);
        public Color AlternativeColor = new Color(1f, 0.79f, 0.14f, 1f);
        public Color ColorProperty => UseAlternativeColor ? AlternativeColor : Color;

        [FoldoutGroup("Field Name Example")]
        [ProgressBar(0f, 10f, ColorGetter = "Color")]
        public float FieldNameExample = 7.5f;

        [FoldoutGroup("Property Name Example")]
        [ProgressBar(0f, 10f, ColorGetter = "ColorProperty")]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [ProgressBar(0f, 10f, ColorGetter = "@UseAlternativeColor ? AlternativeColor : Color")]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [ProgressBar(0f, 10f, ColorGetter = "GetColor")]
        public float MethodNameExample = 7.5f;

        private Color GetColor()
        {
            return UseAlternativeColor ? AlternativeColor : Color;
        }
    }
    // End

    [ResolvedParameterExample]
    public class ProgressBarExamples_BackgroundColorGetter
    {
        public bool UseAlternativeColor;
        public Color Color = new Color(0.11f, 0.77f, 0.5f, 1f);
        public Color AlternativeColor = new Color(1f, 0.79f, 0.14f, 1f);
        public Color ColorProperty => UseAlternativeColor ? AlternativeColor : Color;

        [FoldoutGroup("Field Name Example")]
        [ProgressBar(0f, 10f, BackgroundColorGetter = "Color")]
        public float FieldNameExample = 7.5f;

        [FoldoutGroup("Property Name Example")]
        [ProgressBar(0f, 10f, BackgroundColorGetter = "ColorProperty")]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [ProgressBar(0f, 10f, BackgroundColorGetter = "@UseAlternativeColor ? AlternativeColor : Color")]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [ProgressBar(0f, 10f, BackgroundColorGetter = "GetColor")]
        public float MethodNameExample = 7.5f;

        private Color GetColor()
        {
            return UseAlternativeColor ? AlternativeColor : Color;
        }
    }
    // End

    [ResolvedParameterExample]
    public class ProgressBarExamples_CustomValueStringGetter
    {
        public bool UseAlternativeString;
        public string ValueString = "Custom Value String";
        public string AlternativeString = "Alternative Custom String";
        public string ValueStringProperty => UseAlternativeString ? AlternativeString : ValueString;

        [FoldoutGroup("Field Name Example")]
        [ProgressBar(0f, 10f, CustomValueStringGetter = "$ValueString")]
        public float FieldNameExample = 7.5f;

        [FoldoutGroup("Property Name Example")]
        [ProgressBar(0f, 10f, CustomValueStringGetter = "$ValueStringProperty")]
        public float PropertyNameExample = 7.5f;
        
        [FoldoutGroup("Attribute Expression Example")]
        [ProgressBar(0f, 10f, CustomValueStringGetter = "@\"The current value is:\" + $value")]
        public float AttributeExpressionExample = 7.5f;
        
        [FoldoutGroup("Method Name Example")]
        [ProgressBar(0f, 10f, CustomValueStringGetter = "$GetValueString")]
        public float MethodNameExample = 7.5f;

        private string GetValueString(float value)
        {
            return "The current value is: " + value;
        }
    }
    // End
}