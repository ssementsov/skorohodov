using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class DerivedClass : IInterface1, IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("IInterface1.Method");

        void IInterface2.Method() => Console.WriteLine("IInterface2.Method");
    }
}
