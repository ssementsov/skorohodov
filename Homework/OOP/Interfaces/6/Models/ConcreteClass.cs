using _6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Models
{
    public class ConcreteClass : IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("Method - implementation IInterface1");

        void IInterface2.Method() => Console.WriteLine("Method - implementation IInterface2");
    }
}
