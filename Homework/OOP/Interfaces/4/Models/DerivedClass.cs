using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class DerivedClass : BaseClass, IInterface1, IInterface2
    {
        public void Method1() => Console.WriteLine("Method1() from IInterface1.");

        public void Method2() => Console.WriteLine("Method2() from IInterface2.");
    }
}
