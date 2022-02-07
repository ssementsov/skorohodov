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

            (item as IInterface1).Method();

            (item as IInterface2).Method();

            Console.ReadKey();
        }
    }
}
