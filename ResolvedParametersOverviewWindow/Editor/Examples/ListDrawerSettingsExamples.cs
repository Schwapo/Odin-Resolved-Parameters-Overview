using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using System.Collections.Generic;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_CustomAddFunction
    {
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(CustomAddFunction = "CustomAddFunction")]
        public List<string> MethodNameExample = new List<string>();

        private string CustomAddFunction()
        {
            return "Custom String Added Using: Method Name";
        }
    }
    // End

    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_CustomRemoveElementFunction
    {
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(CustomRemoveElementFunction = "CustomRemoveFunction")]
        public List<string> MethodNameExample = new List<string>() { "Value 1", "Value 2", "Value 3" };

        private void CustomRemoveFunction(List<string> list, string removeElement)
        {
            list.Remove(removeElement);
            Debug.Log("Custom Remove Function Called");
        }
    }
    // End

    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_CustomRemoveIndexFunction
    {
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(CustomRemoveIndexFunction = "CustomRemoveFunction")]
        public List<string> MethodNameExample = new List<string>() { "Value 1", "Value 2", "Value 3" };

        private void CustomRemoveFunction(List<string> list, int index)
        {
            list.RemoveAt(index);
            Debug.Log("Custom Remove Function Called");
        }
    }
    // End

    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_ElementColor
    {
        public bool UseEvenColor; 
        public Color OddColor = new Color(0.11f, 0.77f, 0.5f, 1f);
        public Color EvenColor = new Color(1f, 0.79f, 0.14f, 1f);
        public Color ColorProperty => UseEvenColor ? EvenColor : OddColor;

        [FoldoutGroup("Field Name Example")]
        [ListDrawerSettings(ElementColor = "OddColor")]
        public List<string> FieldNameExample = new List<string> { "Value 1", "Value 2", "Value 3" };
        
        [FoldoutGroup("Property Name Example")]
        [ListDrawerSettings(ElementColor = "ColorProperty")]
        public List<string> PropertyNameExample = new List<string> { "Value 1", "Value 2", "Value 3" };
        
        [FoldoutGroup("Attribute Expression Example")]
        [ListDrawerSettings(ElementColor = "@($index % 2 == 0) ? EvenColor : OddColor")]
        public List<string> AttributeExpressionExample = new List<string> { "Value 1", "Value 2", "Value 3" };
        
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(ElementColor = "GetElementColor")]
        public List<string> MethodNameExample = new List<string> { "Value 1", "Value 2", "Value 3" };

        private Color GetElementColor(int index)
        {
            return index % 2 == 0 ? EvenColor : OddColor;
        }
    }
    // End

    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_OnBeginListElementGUI
    {
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(OnBeginListElementGUI = "BeginElement")]
        public List<string> MethodNameExample = new List<string> { "Value 1", "Value 2", "Value 3" };

        private void BeginElement()
        {
            GUILayout.Label("Injected Before");
        }
    }
    // End

    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_OnEndListElementGUI
    {
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(OnEndListElementGUI = "EndElement")]
        public List<string> MethodNameExample = new List<string> { "Value 1", "Value 2", "Value 3" };

        private void EndElement()
        {
            GUILayout.Label("Injected After");
        }
    }
    // End

    [ResolvedParameterExample]
    public class ListDrawerSettingsExamples_OnTitleBarGUI
    {
        [FoldoutGroup("Method Name Example")]
        [ListDrawerSettings(OnTitleBarGUI = "OnTitleBarGUI")]
        public List<string> MethodNameExample = new List<string> { "Value 1", "Value 2", "Value 3" };

        private void OnTitleBarGUI(List<string> list)
        {
            if (SirenixEditorGUI.ToolbarButton("Log All"))
            {
                list.ForEach(element => Debug.Log(element));
            }
        }
    }
    // End
}