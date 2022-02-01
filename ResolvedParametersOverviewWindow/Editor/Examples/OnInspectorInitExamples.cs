using Sirenix.OdinInspector;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class OnInspectorInitExamples_Action
    {
        [FoldoutGroup("Method Name Example")]
        [OnInspectorInit("OnInspectorInit")]
        public string MethodNameExample;

        private void OnInspectorInit()
        {
            // Initialized, do something
            // [...]
        }
    }
    // End
}