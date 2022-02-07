using System;

namespace _4
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var derivedClassItem = new DerivedClass();
            derivedClassItem.Method();
            derivedClassItem.Method1();
            derivedClassItem.Method2();
            Console.WriteLine("----");

            var baseClassItem = new BaseClass();
            baseClassItem.Method();
            Console.WriteLine("----");

            IInterface1 interfaceOneItem = (IInterface1)derivedClassItem;
            interfaceOneItem.Method1();
            Console.WriteLine("----");


            IInterface2 interfaceTwoItem = (IInterface2)derivedClassItem;
            interfaceTwoItem.Method2();
            Console.WriteLine("----");

            Console.ReadKey();
        }
    }
}
