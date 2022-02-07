using _5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Models
{
    public class ConcreteClass : IInterface2
    {
        public void Method1() => Console.WriteLine("Method1 - implementation IInterface1");

        public void Method2() => Console.WriteLine("Method2 - implementation IInterface2");
    }
}
