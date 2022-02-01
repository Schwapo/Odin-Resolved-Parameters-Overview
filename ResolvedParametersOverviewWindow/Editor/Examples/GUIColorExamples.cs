using Sirenix.OdinInspector;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class GUIColorExamples_GetColor
    {
        public bool UseRed;
        public Color Color = Color.green;
        public Color ColorProperty => Color;

        [FoldoutGroup("Field Name Example")]
        [GUIColor("$Color")]
        public string FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [GUIColor("$ColorProperty")]
        public string PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [GUIColor("@UseRed ? UnityEngine.Color.red : UnityEngine.Color.green")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [GUIColor("$GetColor")]
        public string MethodNameExample;

        private Color GetColor()
        {
            return UseRed ? Color.red : Color.green;
        }
    }
    // End
}