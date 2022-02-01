using Sirenix.OdinInspector;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class OnInspectorDisposeExamples_Action
    {
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("It's hard to preview this since disposing isn't manually controlled")]
        [OnInspectorDispose("@Debug.Log(\"Disposed\")")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [InfoBox("It's hard to preview this since disposing isn't manually controlled")]
        [OnInspectorDispose("OnInspectorDispose")]
        public string MethodNameExample;

        private void OnInspectorDispose()
        {
            Debug.Log("Disposed");
        }
    }
    // End
}