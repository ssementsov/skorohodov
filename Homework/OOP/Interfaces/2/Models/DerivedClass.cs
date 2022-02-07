using _2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Models
{
    public class DerivedClass : IInterface1, IInterface2
    {
        public void Method1() => Console.WriteLine("IInterface1.Method1");

        public void Method2() => Console.WriteLine("IInterface2.Method2");
    }
}
