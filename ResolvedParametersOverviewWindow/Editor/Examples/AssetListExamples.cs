using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class AssetListExamples_CustomFilterMethod
    {
        [FoldoutGroup("Method Name Example")]
        [InfoBox("Should Only Contain Prefabs")]
        [AssetList(CustomFilterMethod = "IsPrefab")]
        public List<GameObject> MethodNameExample = new List<GameObject>();

        private bool IsPrefab(GameObject asset)
        {
            return PrefabUtility.GetPrefabAssetType(asset) == PrefabAssetType.Regular;
        }

        [FoldoutGroup("Attribute Expression Example")]
        [InfoBox("Should Only Contain Textures That Start With TMP")]
        [AssetList(CustomFilterMethod = "@$asset.name.StartsWith(\"TMP\")")]
        public List<Texture> AttributeExpressionExample = new List<Texture>();
    }
    // End
}