using System;
using System.Runtime.CompilerServices;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ResolvedParameterExampleAttribute : Attribute
    {
        public string FilePath { get; private set; }
        public int LineNumber { get; private set; }
        
        public ResolvedParameterExampleAttribute(
            [CallerFilePath] string filePath = "unknown", 
            [CallerLineNumber] int lineNumber = -1)
        {
            FilePath = filePath;
            LineNumber = lineNumber;
        }
    }
}