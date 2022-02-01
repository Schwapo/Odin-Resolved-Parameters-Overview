using Sirenix.OdinInspector;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ColorPaletteExamples_PaletteName
    {
        public bool UseTropical;
        public string TropicalPaletteName = "Tropical";
        public string SepiaPaletteName = "Sepia";
        public string PaletteNameProperty => UseTropical ? TropicalPaletteName : SepiaPaletteName;

        [FoldoutGroup("Field Name Example")]
        [ColorPalette("$SepiaPaletteName")]
        public Color FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [ColorPalette("$PaletteNameProperty")]
        public Color PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [ColorPalette("@UseTropical ? TropicalPaletteName : SepiaPaletteName")]
        public Color AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [ColorPalette("$GetPaletteName")]
        public Color MethodNameExample;

        private string GetPaletteName()
        {
            return UseTropical ? TropicalPaletteName : SepiaPaletteName;
        }
    }
    // End
}