using _5.Models;
using _5.Interfaces;
using System;

namespace _5
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var itemConcreteClass = new ConcreteClass();
            itemConcreteClass.Method1();
            itemConcreteClass.Method2();
            Console.WriteLine("----");

            IInterface1 itemInterfaceOne = (IInterface1)itemConcreteClass;
            itemInterfaceOne.Method1();
            Console.WriteLine("----");

            IInterface2 itemInterfaceTwo = (IInterface2)itemConcreteClass;
            itemInterfaceTwo.Method2();

            Console.ReadKey();
        }
    }
}
