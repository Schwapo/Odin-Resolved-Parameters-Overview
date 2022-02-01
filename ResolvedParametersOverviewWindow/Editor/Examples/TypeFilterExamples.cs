using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schwapo.OdinInspector.Editor.ResolvedParametersOverviewWindow
{
    [ResolvedParameterExample]
    public class TypeFilterExamples_FilterGetter
    {
        /* 
            Note that this example requires Odin's serialization to be enabled to work,
            since it uses types that Unity will not serialize.
            Copy this code into a SerializedMonoBehaviour to preview it.
        */

        [FoldoutGroup("Method Name Example")]
        [TypeFilter(filterGetter: "GetFilteredTypeList")]
        public BaseClass[] Array = new BaseClass[3];

        public IEnumerable<Type> GetFilteredTypeList()
        {
            var q = typeof(BaseClass).Assembly.GetTypes()
                .Where(x => !x.IsAbstract)
                .Where(x => !x.IsGenericTypeDefinition)
                .Where(x => typeof(BaseClass).IsAssignableFrom(x));

            return q;
        }

        public abstract class BaseClass
        {
            public int BaseField;
        }

        public class A1 : BaseClass { public int _A1; }
        public class A2 : A1 { public int _A2; }
        public class A3 : A2 { public int _A3; }
        public class B1 : BaseClass { public int _B1; }
        public class B2 : B1 { public int _B2; }
        public class B3 : B2 { public int _B3; }
    }
    // End
}