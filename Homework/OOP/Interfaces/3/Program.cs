using System;

namespace _3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var my = new DerivedClass();
            IInterface1 myOne = my as IInterface1;
            myOne.Method();

            IInterface2 myTwo = my as IInterface2;
            myTwo.Method();

            Console.ReadKey();
        }
    }
}
