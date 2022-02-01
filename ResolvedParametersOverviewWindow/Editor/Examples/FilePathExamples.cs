using Sirenix.OdinInspector;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class FilePathExamples_ParentFolder
    {
        public bool UseDataPath = true;
        public string ParentFolder = "C:\\";
        public string UnityDataPath => UseDataPath ? UnityEngine.Application.dataPath : ParentFolder;

        [FoldoutGroup("Field Name Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FilePath(ParentFolder = "$ParentFolder")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FilePath(ParentFolder = "$UnityDataPath")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FilePath(ParentFolder = "@UseDataPath ? UnityDataPath : ParentFolder")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [InfoBox("Click the folder icon to see the attribute in effect")]
        [FilePath(ParentFolder = "$GetParentFolder")]
        public string MethodNameExample;

        private string GetParentFolder()
        {
            return UseDataPath ? UnityDataPath : ParentFolder;
        }
    }
    // End

    [ResolvedParameterExample]
    public class FilePathExamples_Extensions
    {
        public bool OnlyAllowImages = true;
        public string AllowedExtensions = "cs, dll, txt, png, jpg";
        public string AllowedExtensionsProperty => OnlyAllowImages ? "png, jpg" : AllowedExtensions;

        [FoldoutGroup("Field Name Example")]
        [FilePath(Extensions = "$AllowedExtensions")]
        public string FieldNameExample;

        [FoldoutGroup("Property Name Example")]
        [FilePath(Extensions = "$AllowedExtensionsProperty")]
        public string PropertyNameExample;

        [FoldoutGroup("Attribute Expression Example")]
        [FilePath(Extensions = "@OnlyAllowImages ? \"png, jpg\" : AllowedExtensions")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")]
        [FilePath(Extensions = "$GetAllowedExtensions")]
        public string MethodNameExample;

        private string GetAllowedExtensions()
        {
            return OnlyAllowImages ? "png, jpg" : AllowedExtensions;
        }
    }
    // End
}