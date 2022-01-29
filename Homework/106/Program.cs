using System;

namespace _106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cSharp = new Book();
            cSharp.Print();

            var cSharp1 = new MyBook();
            cSharp1.Print();

            var cSharp2 = new MyITBook();
            cSharp2.Print();

            Console.ReadKey();
        }
    }
}
