using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using System;
using UnityEditor;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class CustomValueDrawerExamples_Action
    {
        [FoldoutGroup("Method Name Example")]
        [CustomValueDrawer("DrawBoolAsButtons")]
        public bool MethodNameExample;

        private bool DrawBoolAsButtons(bool value, GUIContent label, Func<GUIContent, bool> callNextDrawer)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUI.BeginDisabledGroup(value);
            if (GUILayout.Button("True")) value = true;
            EditorGUI.EndDisabledGroup();

            EditorGUI.BeginDisabledGroup(!value);
            if (GUILayout.Button("False")) value = false;
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(10f);

            EditorGUILayout.LabelField("Default Drawing", SirenixGUIStyles.BoldLabel);
            callNextDrawer(label);

            return value;
        }
    }
    // End
}