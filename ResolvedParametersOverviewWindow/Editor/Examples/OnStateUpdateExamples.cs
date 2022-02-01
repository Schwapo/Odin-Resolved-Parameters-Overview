using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class OnStateUpdateExamples_Action
    {
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("@\"Last Update: \" + lastUpdate")]
        [OnStateUpdate("@lastUpdate = DateTime.Now")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [InfoBox("@\"Last Update: \" + lastUpdate")]
        [OnStateUpdate("OnStateUpdate")]
        public string MethodNameExample;

        private DateTime lastUpdate;

        private void OnStateUpdate()
        {
            lastUpdate = DateTime.Now;
        }
    }
    // End
}