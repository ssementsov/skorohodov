using _7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models
{
    public class ConcreteClass: IInterface2, IInterface1
    {
        void IInterface1.Method() => Console.WriteLine("Method - implementation IInterface 1");

        void IInterface2.Method() => Console.WriteLine("Method - implementation IInterface 2");

        public void Method() => Console.WriteLine("Method - implementation IInterface (1-2)");
    }
}
