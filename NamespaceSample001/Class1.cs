using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceSample001
{
    internal class Class1
    {
        public void Request()
        {
            MethodInfo[]  method = typeof(object).GetType().GetMethods();
        }
    }
}
