using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class OnCollectionChangedExamples_Before
    {
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Edit the collection to see this attribute in effect")]
        [OnCollectionChanged(Before = "@Debug.Log(\"A change is going to occur.\")")]
        public List<string> AttributeExpressionExample = new List<string>();
        
        [FoldoutGroup("Method Name Example")]
        [InfoBox("Edit the collection to see this attribute in effect")]
        [OnCollectionChanged(Before = "BeforeChange")]
        public List<string> MethodNameExample = new List<string>();

        private void BeforeChange(CollectionChangeInfo info)
        {
            Debug.Log("Change of type: " + info.ChangeType + " is going to occur");
        }
    }
    // End

    [ResolvedParameterExample]
    public class OnCollectionChangedExamples_After
    {
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Edit the collection to see this attribute in effect")]
        [OnCollectionChanged(After = "@Debug.Log(\"A change occurred.\")")]
        public List<string> AttributeExpressionExample = new List<string>();
        
        [FoldoutGroup("Method Name Example")]
        [InfoBox("Edit the collection to see this attribute in effect")]
        [OnCollectionChanged(After = "AfterChange")]
        public List<string> MethodNameExample = new List<string>();

        private void AfterChange(CollectionChangeInfo info)
        {
            Debug.Log("Change of type: " + info.ChangeType + " occured");
        }
    }
    // End
}