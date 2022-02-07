using _2.Models;
using System;

namespace _2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            DerivedClass myClass = new ();
            myClass.Method1();
            myClass.Method2();


            Console.ReadKey();
        }
    }
}
