using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class ValueDropdownExamples_ValuesGetter
    {
        public bool UseAlternativeValues;
        public List<string> Values = new List<string> { "Value 1", "Value 2", "Value 3" };
        public List<string> AlternativeValues = new List<string> { "1", "2", "3" };
        public List<string> ValuesProperty => UseAlternativeValues ? AlternativeValues : Values;

        [FoldoutGroup("Field Name Example")]
        [ValueDropdown("@Values")]
        public string FieldNameExample; 

        [FoldoutGroup("Property Name Example")]
        [ValueDropdown("@ValuesProperty")]
        public string PropertyNameExample; 

        [FoldoutGroup("Attribute Expression Example")]
        [ValueDropdown("@UseAlternativeValues ? AlternativeValues : ValuesProperty")]
        public string AttributeExpressionExample; 

        [FoldoutGroup("Method Name Example")]
        [ValueDropdown("GetValues")]
        public string MethodNameExample; 

        private IEnumerable GetValues()
        {
            return UseAlternativeValues ? AlternativeValues : Values;
        }
    }
    // End
}