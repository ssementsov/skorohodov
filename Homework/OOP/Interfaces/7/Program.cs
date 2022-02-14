using _7.Interfaces;
using _7.Models;
using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var item = new ConcreteClass();
            item.Method();

            var item1 = item as IInterface1;
            item1.Method();

            var item2 = item as IInterface2;
            item2.Method();

            Console.ReadKey();
        }
    }
}
