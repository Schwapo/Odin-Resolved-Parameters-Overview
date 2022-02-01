using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    public class ResolvedParameterExample
    {
        private static readonly MethodInfo parseMethod = Type.GetType(
            "Sirenix.OdinInspector.Editor.Examples.SyntaxHighlighter," +
            "Sirenix.OdinInspector.Editor," +
            "Version=1.0.0.0," +
            "Culture=neutral," +
            "PublicKeyToken=null")
            .GetMethod("Parse", BindingFlags.Public | BindingFlags.Static);

        private static readonly Func<string, string> ApplyCodeHighlighting =
            (Func<string, string>)Delegate.CreateDelegate(typeof(Func<string, string>), parseMethod);

        public string Code;
        public string HighlightedCode;

        private PropertyTree tree;

        public ResolvedParameterExample(Type exampleType)
        {
            var exampleAttribute = TypeCache
                .GetTypesWithAttribute<ResolvedParameterExampleAttribute>()
                .Where(type => type == exampleType)
                .Select(type => type.GetAttribute<ResolvedParameterExampleAttribute>())
                .Single();

            var splitCode = File.ReadLines(exampleAttribute.FilePath)
                .Skip(exampleAttribute.LineNumber)
                .TakeWhile(line => !line.TrimStart().StartsWith("// End"));

            Code = string.Join("\n", splitCode);
            HighlightedCode = ApplyCodeHighlighting(Code);

            tree = PropertyTree.Create(Activator.CreateInstance(exampleType));
        }

        public void DrawPreview() => tree.Draw(false);

        public void CollapsePreviews() => tree.RootProperty.Children
            .Recurse().ForEach(child => child.State.Expanded = false);
    }
}