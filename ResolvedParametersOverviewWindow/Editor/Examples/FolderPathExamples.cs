using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class FolderPathExamples_ParentFolder
    {
        public bool UseDataPath = true;
        public string ParentFolder = "C:\\";
        public string UnityDataPath => UseDataPath ? UnityEngine.Application.dataPath : ParentFolder;

        [FoldoutGroup("Field Name Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FolderPath(ParentFolder = "$ParentFolder")]
        public string FieldNameExample;
        
        [FoldoutGroup("Property Name Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FolderPath(ParentFolder = "$UnityDataPath")]
        public string PropertyNameExample;
        
        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FolderPath(ParentFolder = "@UseDataPath ? UnityDataPath : ParentFolder")]
        public string AttributeExpressionExample;
        
        [FoldoutGroup("Method Name Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FolderPath(ParentFolder = "$GetParentFolder")]
        public string MethodNameExample;

        private string GetParentFolder()
        {
            return UseDataPath ? UnityDataPath : ParentFolder;
        }
    }
    // End

}