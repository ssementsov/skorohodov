using _6.Interfaces;
using _6.Models;
using System;

namespace _6
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass concreteClassItem = new ();
            (concreteClassItem as IInterface1).Method();
            Console.WriteLine("----");

            (concreteClassItem as IInterface2).Method();
            Console.WriteLine("----");

            IInterface1 interfaceOneItem = concreteClassItem;
            interfaceOneItem.Method();
            Console.WriteLine("----");

            IInterface2 interfaceTwoItem = concreteClassItem;
            interfaceTwoItem.Method();

            Console.ReadKey();
        }
    }
}
