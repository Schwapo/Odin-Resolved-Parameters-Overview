using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEditor;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class TableMatrixExamples_DrawElementMethod 
    {
        /* 
            Note that this example requires Odin's serialization to be enabled to work,
            since it uses types that Unity will not serialize.
            Copy this code into a SerializedMonoBehaviour to preview it.
        */

        public Color TrueColor = new Color(0.11f, 0.77f, 0.5f, 1f);
        public Color FalseColor = new Color(1f, 0.4f, 0.14f, 1f);

        [FoldoutGroup("Method Name Example")]
        [InfoBox("Paste this code into a Odin serialized object.")]
        [TableMatrix(DrawElementMethod = "DrawAsColoredRect")]
        public bool[,] MethodNameExample = new bool[5, 5];

        private bool DrawAsColoredRect(Rect rect, bool[,] table, int x, int y)
        {
            var value = table[x, y];

            if (Event.current.type == EventType.MouseDown && rect.Contains(Event.current.mousePosition))
            {
                table[x, y] = !value;
            }

            EditorGUI.DrawRect(rect, value ? TrueColor : FalseColor);

            return value;
        }
    }
    // End

    [ResolvedParameterExample]
    public class TableMatrixExamples_HorizontalTitle
    {
        /* 
            Note that this example requires Odin's serialization to be enabled to work,
            since it uses types that Unity will not serialize.
            Copy this code into a SerializedMonoBehaviour to preview it.
            
            Make sure to reselect the object after changing UseAlternativeTitle to see the change in effect.
        */

        public bool UseAlternativeTitle;
        public string Title = "Peace, Love & Ducks";
        public string AlternativeTitle = "Peace, Love & Fenrir";
        public string TitleProperty => UseAlternativeTitle ? AlternativeTitle : Title;

        [FoldoutGroup("Field Name Example")]
        [TableMatrix(HorizontalTitle = "$Title")]
        public bool[,] FieldNameExample = new bool[5, 5];

        [FoldoutGroup("Property Name Example")]
        [TableMatrix(HorizontalTitle = "$TitleProperty")]
        public bool[,] PropertyNameExample = new bool[5, 5];

        [FoldoutGroup("Attribute Expression Example")]
        [TableMatrix(HorizontalTitle = "@UseAlternativeTitle ? AlternativeTitle : Title")]
        public bool[,] AttributeExpressionExample = new bool[5, 5];

        [FoldoutGroup("Method Name Example")]
        [TableMatrix(HorizontalTitle = "$GetTitle")]
        public bool[,] MethodNameExample = new bool[5, 5];

        private string GetTitle()
        {
            return UseAlternativeTitle ? AlternativeTitle : Title;
        }
    }
    // End

    [ResolvedParameterExample]
    public class TableMatrixExamples_VerticalTitle
    {
        /* 
            Note that this example requires Odin's serialization to be enabled to work,
            since it uses types that Unity will not serialize.
            Copy this code into a SerializedMonoBehaviour to preview it.
            
            Make sure to reselect the object after changing UseAlternativeTitle to see the change in effect.
        */
        
        public bool UseAlternativeTitle;
        public string Title = "Peace, Love & Ducks";
        public string AlternativeTitle = "Peace, Love & Fenrir";
        public string TitleProperty => UseAlternativeTitle ? AlternativeTitle : Title;

        [FoldoutGroup("Field Name Example")]
        [TableMatrix(VerticalTitle = "$Title")]
        public bool[,] FieldNameExample = new bool[5, 5];

        [FoldoutGroup("Property Name Example")]
        [TableMatrix(VerticalTitle = "$TitleProperty")]
        public bool[,] PropertyNameExample = new bool[5, 5];

        [FoldoutGroup("Attribute Expression Example")]
        [TableMatrix(VerticalTitle = "@UseAlternativeTitle ? AlternativeTitle : Title")]
        public bool[,] AttributeExpressionExample = new bool[5, 5];

        [FoldoutGroup("Method Name Example")]
        [TableMatrix(VerticalTitle = "$GetTitle")]
        public bool[,] MethodNameExample = new bool[5, 5];

        private string GetTitle()
        {
            return UseAlternativeTitle ? AlternativeTitle : Title;
        }
    }
    // End
}